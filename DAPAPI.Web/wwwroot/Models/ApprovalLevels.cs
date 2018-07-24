using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ApprovalLevels
    {
        public long FarmerId { get; set; }
        public long UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long Id { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
