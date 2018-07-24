using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class QuestionAnswers
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? CustomerId { get; set; }
        public DateTime InsertedAt { get; set; }
        public int? QuestionId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Value { get; set; }

        public Customers Customer { get; set; }
        public Questions Question { get; set; }
    }
}
