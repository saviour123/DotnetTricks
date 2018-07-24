using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class FingerPrints
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? ImageId { get; set; }
        public int? PersonId { get; set; }
        public int? CustomerId { get; set; }

        public Customers Customer { get; set; }
        public Pictures Image { get; set; }
        public People Person { get; set; }
    }
}
