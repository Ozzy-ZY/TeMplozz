﻿using System.Security.Claims;
using Application.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController(AuthService authService,ILogger<AuthController> logger) : ControllerBase
{
    [HttpPost("RegisterUser")]
    [AllowAnonymous]
    public async Task<IActionResult> RegisterUser([FromBody] RegisterDto registerDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var result = await authService.RegisterAsync(registerDto,"User");
        if (!result.Success)
        {
            return BadRequest(result);
        }
        return Ok(result);
    }

    [HttpPost("RegisterAdmin")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> RegisterAdmin([FromBody] RegisterDto registerDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var result = await authService.RegisterAsync(registerDto,"Admin");
        if (!result.Success)
        {
            return BadRequest(result);
        }
        return Ok(result);
    }
    [HttpPost("LoginUser")]
    [AllowAnonymous]
    public async Task<IActionResult> LoginUser([FromBody] LoginDto loginDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var result = await authService.LoginAsync(loginDto);
        if (!result.Success)
        {
            return BadRequest(result);
        }
        return Ok(result);
    }

    [HttpPost("Logout")]
    [Authorize]
    public async Task<IActionResult> RevokeToken(string refreshToken)
    {
        try
        {
            var success = await authService.RevokeTokenAsync(refreshToken, "Mazag Ozzy");
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }
        catch (SecurityTokenException e)
        {
            return Unauthorized(new {e.Message });
        }
        catch (Exception e)
        {
            logger.LogError(e, "An unexpected error occured during Revoke token");
            return StatusCode(500, new {Message = "error occured during Revoke token"});
        }
    }
    [HttpPost("RefreshToken")]
    [AllowAnonymous]
    public async Task<IActionResult> RefreshToken(string refreshToken)
    {
        try
        {
            var result = await authService.RefreshTokenAsync(refreshToken);
            return Ok(result);
        }
        catch (SecurityTokenException e)
        {
            return Unauthorized(new { e.Message });
        }
        catch (Exception e)
        {
            logger.LogError(e, "An unexpected error occured during Refresh token");
            return StatusCode(500, new {Message = "error occured during Refresh token"});
        }
    }


}