using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.DTOs.Account
{
    public class LoginRequest
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
