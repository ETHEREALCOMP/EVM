﻿namespace EVM.Services.Features.Identity;

public class JwtOptions
{
    public static readonly string Path = "Jwt";

    public required string Issuer { get; set; }

    public required string Audience { get; set; }

    public required string Key { get; set; }

    public int LifetimeDays { get; set; }

    public int RefreshLifetimeDays { get; set; }

    public int ExpirationMinutes { get; set; }
}