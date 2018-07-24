using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Customers
    {
        public long Id { get; set; }
        public DateTime ActivatedDate { get; set; }
        public bool? Active { get; set; }
        public long? AgentAssignedId { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string Bbid { get; set; }
        public long? BranchId { get; set; }
        public long ClientId { get; set; }
        public DateTime ClosedDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? GroupId { get; set; }
        public bool IsCorporate { get; set; }
        public bool IsGroup { get; set; }
        public bool? IsIndividual { get; set; }
        public string Meta { get; set; }
        public string Number { get; set; }
        public long? OrganizationId { get; set; }
        public long? PersonId { get; set; }
        public long? ProfilePictureId { get; set; }
        public long? RelationshipOfficerId { get; set; }
        public bool SelfServiceEnabled { get; set; }
        public long? SignatureId { get; set; }
        public string Status { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UserId { get; set; }
    }
}
