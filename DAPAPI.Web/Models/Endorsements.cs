using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Endorsements
    {
        public int Id { get; set; }
        public int? CommentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public int? EndorsementPhotoId { get; set; }
        public int? TransactionDetailId { get; set; }
        public int TransactionId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Notes Comment { get; set; }
        public Customers Customer { get; set; }
        public Pictures EndorsementPhoto { get; set; }
        public TransactionDetails TransactionDetail { get; set; }
    }
}
