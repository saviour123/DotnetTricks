using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class QuestionOptions
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? QuestionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Value { get; set; }
    }
}
