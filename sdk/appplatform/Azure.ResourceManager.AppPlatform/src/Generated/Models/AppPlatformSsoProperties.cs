// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Single sign-on related configuration. </summary>
    public partial class AppPlatformSsoProperties
    {
        /// <summary> Initializes a new instance of AppPlatformSsoProperties. </summary>
        public AppPlatformSsoProperties()
        {
            Scope = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppPlatformSsoProperties. </summary>
        /// <param name="scope"> It defines the specific actions applications can be allowed to do on a user&apos;s behalf. </param>
        /// <param name="clientId"> The public identifier for the application. </param>
        /// <param name="clientSecret"> The secret known only to the application and the authorization server. </param>
        /// <param name="issuerUri"> The URI of Issuer Identifier. </param>
        internal AppPlatformSsoProperties(IList<string> scope, string clientId, string clientSecret, Uri issuerUri)
        {
            Scope = scope;
            ClientId = clientId;
            ClientSecret = clientSecret;
            IssuerUri = issuerUri;
        }

        /// <summary> It defines the specific actions applications can be allowed to do on a user&apos;s behalf. </summary>
        public IList<string> Scope { get; }
        /// <summary> The public identifier for the application. </summary>
        public string ClientId { get; set; }
        /// <summary> The secret known only to the application and the authorization server. </summary>
        public string ClientSecret { get; set; }
        /// <summary> The URI of Issuer Identifier. </summary>
        public Uri IssuerUri { get; set; }
    }
}
