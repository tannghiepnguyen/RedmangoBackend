﻿using Microsoft.AspNetCore.Identity;

namespace Redmango_API.Models;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
}