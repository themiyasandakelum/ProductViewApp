﻿using Services.AuthAPI.Models;

namespace Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(Users users);
    }
}
