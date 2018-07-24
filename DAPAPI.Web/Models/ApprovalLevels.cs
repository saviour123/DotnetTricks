using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ApprovalLevels
    {
        public int FarmerId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Farmers Farmer { get; set; }
        public Users User { get; set; }
    }
}
