﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license.txt
 */

namespace Thinktecture.AuthorizationServer.Models
{
    public class Client
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public ClientAuthenticationMethod AuthenticationMethod { get; set; }
        public string Name { get; set; }
        public OAuthFlow Flow { get; set; }
        public bool AllowRefreshToken { get; set; }

        public RedirectUris RedirectUris { get; set; }
    }
}
