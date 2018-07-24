using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class MaritalDetails
    {
        public long Id { get; set; }
        public string MaritalStatus { get; set; }
        public long SpouseId { get; set; }
    }
}
