﻿using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class OauthApplications
    {
        public OauthApplications()
        {
            OauthAccessGrants = new HashSet<OauthAccessGrants>();
            OauthAccessTokens = new HashSet<OauthAccessTokens>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Uid { get; set; }
        public string Secret { get; set; }
        public string RedirectUri { get; set; }
        public string Scopes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? OwnerId { get; set; }
        public string OwnerType { get; set; }

        public ICollection<OauthAccessGrants> OauthAccessGrants { get; set; }
        public ICollection<OauthAccessTokens> OauthAccessTokens { get; set; }
    }
}
