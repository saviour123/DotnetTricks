using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Contacts
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
