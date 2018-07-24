using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Tasks
    {
        public Tasks()
        {
            Activities = new HashSet<Activities>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CompletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public DateTime DueAt { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int BackOfficerAssignedId { get; set; }
        public int TaskCreatorId { get; set; }

        public Backofficers BackOfficerAssigned { get; set; }
        public Clients Client { get; set; }
        public Backofficers TaskCreator { get; set; }
        public ICollection<Activities> Activities { get; set; }
    }
}
