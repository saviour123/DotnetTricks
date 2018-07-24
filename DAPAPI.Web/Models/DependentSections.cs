using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class DependentSections
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string AnswerType { get; set; }
        public int? DependentSectionId { get; set; }
        public int? QuestionId { get; set; }

        public FormSections DependentSection { get; set; }
        public Questions Question { get; set; }
    }
}
