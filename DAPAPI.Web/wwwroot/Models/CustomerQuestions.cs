using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class CustomerQuestions
    {
        public long Id { get; set; }
        public string FieldName { get; set; }
        public DateTime InsertedAt { get; set; }
        public long? QuestionId { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
