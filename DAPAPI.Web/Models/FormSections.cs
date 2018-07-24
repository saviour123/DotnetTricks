using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class FormSections
    {
        public FormSections()
        {
            DependentSections = new HashSet<DependentSections>();
            InverseSection = new HashSet<FormSections>();
            Questions = new HashSet<Questions>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public int? FormId { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
        public int? SectionId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Forms Form { get; set; }
        public FormSections Section { get; set; }
        public ICollection<DependentSections> DependentSections { get; set; }
        public ICollection<FormSections> InverseSection { get; set; }
        public ICollection<Questions> Questions { get; set; }
    }
}
