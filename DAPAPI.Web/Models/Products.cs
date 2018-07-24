using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Products
    {
        public Products()
        {
            ClientProductSubscriptions = new HashSet<ClientProductSubscriptions>();
            ProductServices = new HashSet<ProductServices>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? IconId { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Pictures Icon { get; set; }
        public ICollection<ClientProductSubscriptions> ClientProductSubscriptions { get; set; }
        public ICollection<ProductServices> ProductServices { get; set; }
    }
}
