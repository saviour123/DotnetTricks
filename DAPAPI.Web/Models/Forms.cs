using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Forms
    {
        public Forms()
        {
            FormSections = new HashSet<FormSections>();
            Questions = new HashSet<Questions>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public ICollection<FormSections> FormSections { get; set; }
        public ICollection<Questions> Questions { get; set; }
    }
}
