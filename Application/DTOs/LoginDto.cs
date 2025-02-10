﻿using System.ComponentModel.DataAnnotations;

namespace Application.DTOs;

public class LoginDto
{
    public string EmailOrUsername { get; set; }
    public string Password { get; set; }
}