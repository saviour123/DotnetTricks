using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class QuestionAnswers
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public long? CustomerId { get; set; }
        public DateTime InsertedAt { get; set; }
        public long? QuestionId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Value { get; set; }
    }
}
