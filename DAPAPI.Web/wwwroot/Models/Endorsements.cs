using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Endorsements
    {
        public long Id { get; set; }
        public long? CommentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CustomerId { get; set; }
        public long? EndorsementPhotoId { get; set; }
        public long? TransactionDetailId { get; set; }
        public long TransactionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
