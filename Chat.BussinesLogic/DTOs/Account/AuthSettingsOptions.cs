using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.DTOs.Account
{
    public class AuthSettingsOptions
    {
        public const string SectionName = "AuthSettings";
        public string SecretKey { get; set; }
        public TimeSpan Expires { get; set; }
    }
}
