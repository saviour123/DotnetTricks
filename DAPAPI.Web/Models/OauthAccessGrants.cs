﻿using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class OauthAccessGrants
    {
        public int Id { get; set; }
        public int ResourceOwnerId { get; set; }
        public int ApplicationId { get; set; }
        public string Token { get; set; }
        public int ExpiresIn { get; set; }
        public string RedirectUri { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? RevokedAt { get; set; }
        public string Scopes { get; set; }

        public OauthApplications Application { get; set; }
        public Users ResourceOwner { get; set; }
    }
}
