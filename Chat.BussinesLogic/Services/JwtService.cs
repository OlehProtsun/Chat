using Chat.BussinesLogic.DTOs.Account;
using Chat.DataAccess.Entity.User;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Chat.BussinesLogic.Services
{
    public class JwtService(IOptions<AuthSettingsOptions> options)
    {
        public string GenerateToken(UserEntity user)
        {
            var claims = new List<Claim>
            {
                new Claim("userName", user.Name),
                new Claim("userId", user.Id.ToString())
            };

            var jwtToken = new JwtSecurityToken(
                expires: DateTime.UtcNow.Add(options.Value.Expires),
                claims: claims,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.Value.SecretKey)), SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
    }
}
