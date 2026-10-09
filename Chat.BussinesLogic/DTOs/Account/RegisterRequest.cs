using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.DTOs.Account
{
    public class RegisterRequest
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PasswordMatched { get; set; } = null!;
    }
}
