using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class DependentQuestions
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string AnswerType { get; set; }
        public int? DependentQuestionId { get; set; }
        public int? QuestionId { get; set; }

        public Questions DependentQuestion { get; set; }
        public Questions Question { get; set; }
    }
}
