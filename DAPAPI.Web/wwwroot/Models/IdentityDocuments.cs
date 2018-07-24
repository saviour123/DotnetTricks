using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class IdentityDocuments
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? DocumentHolderId { get; set; }
        public string DocumentType { get; set; }
        public long? ImageId { get; set; }
        public DateTime IssuedDate { get; set; }
        public string IssuingAuthority { get; set; }
        public string Number { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime ValidUntil { get; set; }
        public bool Verified { get; set; }
    }
}
