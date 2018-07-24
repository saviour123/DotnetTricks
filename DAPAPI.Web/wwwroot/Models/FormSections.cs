using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class FormSections
    {
        public FormSections()
        {
            InverseSection = new HashSet<FormSections>();
        }

        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public long? FormId { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
        public long? SectionId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public FormSections Section { get; set; }
        public ICollection<FormSections> InverseSection { get; set; }
    }
}
