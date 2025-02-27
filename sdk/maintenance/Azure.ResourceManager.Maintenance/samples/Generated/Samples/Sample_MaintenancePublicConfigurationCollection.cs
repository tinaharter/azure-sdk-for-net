// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Maintenance.Samples
{
    public partial class Sample_MaintenancePublicConfigurationCollection
    {
        // PublicMaintenanceConfigurations_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PublicMaintenanceConfigurationsList()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/preview/2023-09-01-preview/examples/PublicMaintenanceConfigurations_List.json
            // this example is just showing the usage of "PublicMaintenanceConfigurations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this MaintenancePublicConfigurationResource
            MaintenancePublicConfigurationCollection collection = subscriptionResource.GetMaintenancePublicConfigurations();

            // invoke the operation and iterate over the result
            await foreach (MaintenancePublicConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MaintenanceConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PublicMaintenanceConfigurations_GetForResource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PublicMaintenanceConfigurationsGetForResource()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/preview/2023-09-01-preview/examples/PublicMaintenanceConfigurations_GetForResource.json
            // this example is just showing the usage of "PublicMaintenanceConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this MaintenancePublicConfigurationResource
            MaintenancePublicConfigurationCollection collection = subscriptionResource.GetMaintenancePublicConfigurations();

            // invoke the operation
            string resourceName = "configuration1";
            MaintenancePublicConfigurationResource result = await collection.GetAsync(resourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MaintenanceConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PublicMaintenanceConfigurations_GetForResource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PublicMaintenanceConfigurationsGetForResource()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/preview/2023-09-01-preview/examples/PublicMaintenanceConfigurations_GetForResource.json
            // this example is just showing the usage of "PublicMaintenanceConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this MaintenancePublicConfigurationResource
            MaintenancePublicConfigurationCollection collection = subscriptionResource.GetMaintenancePublicConfigurations();

            // invoke the operation
            string resourceName = "configuration1";
            bool result = await collection.ExistsAsync(resourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PublicMaintenanceConfigurations_GetForResource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PublicMaintenanceConfigurationsGetForResource()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/preview/2023-09-01-preview/examples/PublicMaintenanceConfigurations_GetForResource.json
            // this example is just showing the usage of "PublicMaintenanceConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this MaintenancePublicConfigurationResource
            MaintenancePublicConfigurationCollection collection = subscriptionResource.GetMaintenancePublicConfigurations();

            // invoke the operation
            string resourceName = "configuration1";
            NullableResponse<MaintenancePublicConfigurationResource> response = await collection.GetIfExistsAsync(resourceName);
            MaintenancePublicConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MaintenanceConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
