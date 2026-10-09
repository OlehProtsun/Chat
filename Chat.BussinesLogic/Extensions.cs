using Chat.BussinesLogic.Abstraction;
using Chat.BussinesLogic.DTOs.Account;
using Chat.BussinesLogic.Services;
using Chat.DataAccess.Abstractions.Repository;
using Chat.DataAccess.Abstractions.UnitOfWork;
using Chat.DataAccess.Entity.User;
using Chat.DataAccess.ORM.EntityFramework;
using Chat.DataAccess.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic
{
    public static class Extensions
    {
        public static void AddBussinesLogic(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.Configure<AuthSettingsOptions>(configuration.GetSection(AuthSettingsOptions.SectionName));

            serviceCollection.AddScoped<JwtService>();
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<IAccountService, AccountService>();
            serviceCollection.AddScoped<IPasswordHasher<UserEntity>, PasswordHasher<UserEntity>>();
            serviceCollection.AddHttpContextAccessor();
            var authSettings = configuration.GetSection(AuthSettingsOptions.SectionName).Get<AuthSettingsOptions>();
            serviceCollection.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(o =>
                {
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(authSettings.SecretKey)),
                    };

                    o.Events = new JwtBearerEvents
                    {
                        OnMessageReceived = context =>
                        {
                            context.Token = context.Request.Cookies[AuthCookiesNames.AuthCookieName];

                            return Task.CompletedTask;
                        }
                    };
                });

        }

    }
}
