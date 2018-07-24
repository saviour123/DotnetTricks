using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class DonationProjects
    {
        public long Id { get; set; }
        public string AccountNumber { get; set; }
        public bool Active { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CustomerId { get; set; }
        public string ReceiptImageContentType { get; set; }
        public string ReceiptImageFileName { get; set; }
        public int? ReceiptImageFileSize { get; set; }
        public DateTime? ReceiptImageUpdatedAt { get; set; }
        public string ReceiptTemplate { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
