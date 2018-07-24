using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class CustomerQuestions
    {
        public int Id { get; set; }
        public string FieldName { get; set; }
        public DateTime InsertedAt { get; set; }
        public int? QuestionId { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Questions Question { get; set; }
    }
}
