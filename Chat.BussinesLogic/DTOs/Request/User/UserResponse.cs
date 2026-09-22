using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.DTOs.Request.User
{
    public class UserResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Password { get; set; } = null!;

    }
}
