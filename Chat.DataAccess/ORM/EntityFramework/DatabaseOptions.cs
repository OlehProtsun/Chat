using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.ORM.EntityFramework
{
    public class DatabaseOptions
    {
        public const string SectionName = "Database";

        public string ConnectionString { get; set; } = null!;
    }
}
