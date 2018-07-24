using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class TransactionReports
    {
        public TransactionReports()
        {
            TransactionBatches = new HashSet<TransactionBatches>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Current { get; set; }
        public int? DocumentId { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public Documents Document { get; set; }
        public ICollection<TransactionBatches> TransactionBatches { get; set; }
    }
}
