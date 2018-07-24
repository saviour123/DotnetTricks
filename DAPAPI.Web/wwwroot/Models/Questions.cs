using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Questions
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public long? FormId { get; set; }
        public string Meta { get; set; }
        public int? Order { get; set; }
        public long? QuestionTypeId { get; set; }
        public bool? Required { get; set; }
        public long? SectionId { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
