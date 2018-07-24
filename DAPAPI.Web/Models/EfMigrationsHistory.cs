using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class EfMigrationsHistory
    {
        public string MigrationId { get; set; }
        public string ProductVersion { get; set; }
    }
}
