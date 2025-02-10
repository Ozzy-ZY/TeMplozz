﻿using Microsoft.AspNetCore.Identity;

namespace Domain.Models;

public class AppUser:IdentityUser<int>
{
    public override string UserName { get; set; }
    public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.UtcNow;
    public string ImageUrl { get; set; }
    public ulong RowVersion { get; set; }
}