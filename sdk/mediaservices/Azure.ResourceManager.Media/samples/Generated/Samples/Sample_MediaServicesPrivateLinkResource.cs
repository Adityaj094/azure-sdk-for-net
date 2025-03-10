// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_MediaServicesPrivateLinkResource
    {
        // Get details of a group ID.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDetailsOfAGroupID()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Accounts/stable/2021-11-01/examples/private-link-resources-get-by-name.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesPrivateLinkResource created on azure
            // for more information of creating MediaServicesPrivateLinkResource, please refer to the document of MediaServicesPrivateLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso";
            string accountName = "contososports";
            string name = "keydelivery";
            ResourceIdentifier mediaServicesPrivateLinkResourceId = MediaServicesPrivateLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, name);
            MediaServicesPrivateLinkResource mediaServicesPrivateLinkResource = client.GetMediaServicesPrivateLinkResource(mediaServicesPrivateLinkResourceId);

            // invoke the operation
            MediaServicesPrivateLinkResource result = await mediaServicesPrivateLinkResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaServicesPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
