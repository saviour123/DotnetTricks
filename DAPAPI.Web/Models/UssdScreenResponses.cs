using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UssdScreenResponses
    {
        public int Id { get; set; }
        public int? AnswerId { get; set; }
        public string AnswerText { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public int? ScreenId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public UssdScreenOptions Answer { get; set; }
        public Customers Customer { get; set; }
        public UssdScreens Screen { get; set; }
    }
}
