﻿using Application.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController(AuthService authService) : ControllerBase
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
}