using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class QuestionOptions
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? QuestionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Value { get; set; }

        public Questions Question { get; set; }
    }
}
