using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.DTOs.Account
{
    public static class AuthStatuses
    {
        public const string Success = "Success";
        public const string Failed = "Failed";
        public const string InvalidCredentials = "InvalidCredentials";
        public const string UserAlreadyExists = "UserAlreadyExists";
    }
}
