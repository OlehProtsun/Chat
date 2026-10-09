using Chat.BussinesLogic.Abstraction;
using Chat.BussinesLogic.DTOs.Account;
using Chat.BussinesLogic.DTOs.User;
using Chat.DataAccess.Abstractions.Repository;
using Chat.DataAccess.Abstractions.UnitOfWork;
using Chat.DataAccess.Entity.User;
using Chat.DataAccess.ORM.EntityFramework;
using Chat.DataAccess.Repository;
using Chat.Domain.Entity.Auth;
using Chat.Domain.Enums.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.Services
{
    public class AccountService(
        IUserRepository userRepository, 
        IUnitOfWork unitOfWork, 
        IPasswordHasher<UserEntity> passwordHasher, 
        JwtService jwtService, 
        IHttpContextAccessor httpContextAccessor, 
        IOptions<AuthSettingsOptions> options) : IAccountService
    {
        public async Task<AuthResponse> Login(LoginRequest request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetByNameAsync(request.UserName, cancellationToken);

            if (user is null)
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }

            var passwordCheckResult = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);
            
            if (passwordCheckResult == PasswordVerificationResult.Failed)
            {
                throw new UnauthorizedAccessException(
                    "Invalid username or password.");
            }


            //Token

            var token = jwtService.GenerateToken(user);

            httpContextAccessor.HttpContext?.Response.Cookies.Append(
                AuthCookiesNames.AuthCookieName,
                token,
                new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict,
                    Expires = DateTime.UtcNow.Add(options.Value.Expires),
                });

            return new AuthResponse
            {
                Id = user.Id,
                Username = user.Name,
                AuthStatus = AuthStatuses.Success,
            };
        }

        public async Task<AuthResponse> Register(RegisterRequest request, CancellationToken cancellationToken)
        {
            //Validate

            var existingUser = await userRepository.GetByNameAsync(
                request.UserName,
                cancellationToken);

            if (existingUser is not null)
            {
                throw new ArgumentException("User with this username already exists.");
            }

            if (request.Password != request.PasswordMatched)
            {
                throw new ArgumentException("Passwords do not match.");
            }


            var user = new UserEntity
            {
                Id = Guid.NewGuid(),
                Name = request.UserName,
            };

            //Password Hasing
            var passwordHash = passwordHasher.HashPassword(user, request.Password);
            user.PasswordHash = passwordHash;

            //Roles
            user.UserRoles.Add(new RolesUsersEntity
            {
                RoleId = SystemRoleIds.User
            });

            //Entity Create
            await userRepository.CreateAsync(user, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            //Token

            return new AuthResponse
            {
                Id = user.Id,
                Username = user.Name,
                AuthStatus = AuthStatuses.Success
            };

        }
    }
}
