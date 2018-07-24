using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Contacts
    {
        public Contacts()
        {
            EmailAddresses = new HashSet<EmailAddresses>();
            Groups = new HashSet<Groups>();
            Organizations = new HashSet<Organizations>();
            Partners = new HashSet<Partners>();
            People = new HashSet<People>();
            PhoneNumbers = new HashSet<PhoneNumbers>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<EmailAddresses> EmailAddresses { get; set; }
        public ICollection<Groups> Groups { get; set; }
        public ICollection<Organizations> Organizations { get; set; }
        public ICollection<Partners> Partners { get; set; }
        public ICollection<People> People { get; set; }
        public ICollection<PhoneNumbers> PhoneNumbers { get; set; }
    }
}
