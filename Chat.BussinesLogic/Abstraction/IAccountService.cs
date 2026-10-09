using Chat.BussinesLogic.DTOs.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.Abstraction
{
    public interface IAccountService
    {
        Task<AuthResponse> Login(LoginRequest request, CancellationToken cancellationToken = default);
        Task<AuthResponse> Register(RegisterRequest request, CancellationToken cancellationToken = default);
    }
}
