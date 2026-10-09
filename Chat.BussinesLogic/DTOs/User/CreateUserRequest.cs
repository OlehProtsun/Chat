using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.DTOs.User
{
    public class CreateUserRequest
    {
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
