using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ProductServices
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ProductId { get; set; }
        public int ServiceId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Products Product { get; set; }
        public Services Service { get; set; }
    }
}
