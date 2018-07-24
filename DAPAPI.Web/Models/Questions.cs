using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Questions
    {
        public Questions()
        {
            CustomerQuestions = new HashSet<CustomerQuestions>();
            DependentQuestionsDependentQuestion = new HashSet<DependentQuestions>();
            DependentQuestionsQuestion = new HashSet<DependentQuestions>();
            DependentSections = new HashSet<DependentSections>();
            QuestionAnswers = new HashSet<QuestionAnswers>();
            QuestionOptions = new HashSet<QuestionOptions>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public int? FormId { get; set; }
        public string Meta { get; set; }
        public int? Order { get; set; }
        public int? QuestionTypeId { get; set; }
        public bool? Required { get; set; }
        public int? SectionId { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Forms Form { get; set; }
        public QuestionTypes QuestionType { get; set; }
        public FormSections Section { get; set; }
        public ICollection<CustomerQuestions> CustomerQuestions { get; set; }
        public ICollection<DependentQuestions> DependentQuestionsDependentQuestion { get; set; }
        public ICollection<DependentQuestions> DependentQuestionsQuestion { get; set; }
        public ICollection<DependentSections> DependentSections { get; set; }
        public ICollection<QuestionAnswers> QuestionAnswers { get; set; }
        public ICollection<QuestionOptions> QuestionOptions { get; set; }
    }
}
