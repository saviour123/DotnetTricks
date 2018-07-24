using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Documents
    {
        public Documents()
        {
            TransactionReports = new HashSet<TransactionReports>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedById { get; set; }
        public string DocumentType { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public Backofficers CreatedBy { get; set; }
        public ICollection<TransactionReports> TransactionReports { get; set; }
    }
}
