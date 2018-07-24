using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class FingerPrints
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public long? ImageId { get; set; }
        public long? PersonId { get; set; }
        public long? CustomerId { get; set; }
    }
}
