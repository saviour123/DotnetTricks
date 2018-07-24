using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class CollectionCentres
    {
        public long Id { get; set; }
        public string Centre { get; set; }
        public long? RegionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? IsArchived { get; set; }
    }
}
