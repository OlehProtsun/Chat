using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.DTOs.Account
{
    public class AuthResponse
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = null!;
        public string AuthStatus { get; set; } = null!;
    }
}
