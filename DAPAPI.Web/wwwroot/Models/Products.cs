using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Products
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? IconId { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
