using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Agents
    {
        public long Id { get; set; }
        public bool? Active { get; set; }
        public bool Archived { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsSuperAgent { get; set; }
        public long? PersonId { get; set; }
        public long? RegisteredPhoneNumberId { get; set; }
        public long SupplierId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CollectionCentreId { get; set; }
    }
}
