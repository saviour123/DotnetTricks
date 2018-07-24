using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Tasks
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public DateTime CompletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public DateTime DueAt { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long BackOfficerAssignedId { get; set; }
        public long TaskCreatorId { get; set; }
    }
}
