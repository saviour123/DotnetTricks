using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Customization
    {
        public Customization()
        {
            AccountCustomizations = new HashSet<AccountCustomizations>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<AccountCustomizations> AccountCustomizations { get; set; }
    }
}
