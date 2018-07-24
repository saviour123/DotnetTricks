using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class QuestionTypes
    {
        public long Id { get; set; }
        public DateTime InsertedAt { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
