using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UssdFlows
    {
        public UssdFlows()
        {
            UssdScreens = new HashSet<UssdScreens>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? InitialScreenId { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public UssdScreens InitialScreen { get; set; }
        public ICollection<UssdScreens> UssdScreens { get; set; }
    }
}
