using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class MaritalDetails
    {
        public MaritalDetails()
        {
            People = new HashSet<People>();
        }

        public int Id { get; set; }
        public string MaritalStatus { get; set; }
        public int SpouseId { get; set; }

        public People Spouse { get; set; }
        public ICollection<People> People { get; set; }
    }
}
