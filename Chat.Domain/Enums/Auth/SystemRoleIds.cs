using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Domain.Enums.Auth
{
    public static class SystemRoleIds
    {
        public static readonly Guid User =
            Guid.Parse("a14ce4a1-862d-4f95-8c4e-c2560f6a04ad");

        public static readonly Guid Admin =
            Guid.Parse("b26d3ab3-405e-40d8-b59f-f8b9c183a9e2");
    }
}
