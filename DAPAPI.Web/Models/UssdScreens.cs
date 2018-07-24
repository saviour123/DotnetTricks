using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UssdScreens
    {
        public UssdScreens()
        {
            UssdFlows = new HashSet<UssdFlows>();
            UssdScreenOptionsNextScreen = new HashSet<UssdScreenOptions>();
            UssdScreenOptionsScreen = new HashSet<UssdScreenOptions>();
            UssdScreenResponses = new HashSet<UssdScreenResponses>();
        }

        public int Id { get; set; }
        public int? ActionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Meta { get; set; }
        public bool? Required { get; set; }
        public int? ScreenTypeId { get; set; }
        public string Title { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? UssdFlowId { get; set; }

        public UssdActions Action { get; set; }
        public ScreenTypes ScreenType { get; set; }
        public UssdFlows UssdFlow { get; set; }
        public ICollection<UssdFlows> UssdFlows { get; set; }
        public ICollection<UssdScreenOptions> UssdScreenOptionsNextScreen { get; set; }
        public ICollection<UssdScreenOptions> UssdScreenOptionsScreen { get; set; }
        public ICollection<UssdScreenResponses> UssdScreenResponses { get; set; }
    }
}
