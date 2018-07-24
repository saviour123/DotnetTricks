using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ProductServices
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long ProductId { get; set; }
        public long ServiceId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
