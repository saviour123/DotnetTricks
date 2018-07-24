using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UssdScreenOptions
    {
        public UssdScreenOptions()
        {
            UssdScreenResponses = new HashSet<UssdScreenResponses>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? NextScreenId { get; set; }
        public string Option { get; set; }
        public int? ScreenId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public UssdScreens NextScreen { get; set; }
        public UssdScreens Screen { get; set; }
        public ICollection<UssdScreenResponses> UssdScreenResponses { get; set; }
    }
}
