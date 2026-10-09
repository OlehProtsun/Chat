using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.DTOs.User
{
    public class UpdateUserRequest
    {
        public string UserId { get; set; } = null!;
        public string newName { get; set; } = null!;
    }
}
