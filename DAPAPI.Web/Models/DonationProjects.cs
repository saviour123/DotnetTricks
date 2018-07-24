using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class DonationProjects
    {
        public DonationProjects()
        {
            DonationProjectAssignments = new HashSet<DonationProjectAssignments>();
            Donors = new HashSet<Donors>();
            TransactionBatches = new HashSet<TransactionBatches>();
        }

        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public bool Active { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public string ReceiptImageContentType { get; set; }
        public string ReceiptImageFileName { get; set; }
        public int? ReceiptImageFileSize { get; set; }
        public DateTime? ReceiptImageUpdatedAt { get; set; }
        public string ReceiptTemplate { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public Customers Customer { get; set; }
        public ICollection<DonationProjectAssignments> DonationProjectAssignments { get; set; }
        public ICollection<Donors> Donors { get; set; }
        public ICollection<TransactionBatches> TransactionBatches { get; set; }
    }
}
