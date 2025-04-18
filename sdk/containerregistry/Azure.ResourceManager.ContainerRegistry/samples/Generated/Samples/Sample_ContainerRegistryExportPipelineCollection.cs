// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerRegistry.Samples
{
    public partial class Sample_ContainerRegistryExportPipelineCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ExportPipelineCreate()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/ExportPipelineCreate.json
            // this example is just showing the usage of "ExportPipelines_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryExportPipelineResource
            ContainerRegistryExportPipelineCollection collection = containerRegistry.GetContainerRegistryExportPipelines();

            // invoke the operation
            string exportPipelineName = "myExportPipeline";
            ContainerRegistryExportPipelineData data = new ContainerRegistryExportPipelineData
            {
                Location = new AzureLocation("westus"),
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                Target = new ExportPipelineTargetProperties(new Uri("https://myvault.vault.azure.net/secrets/acrexportsas"))
                {
                    PipelineTargetType = "AzureStorageBlobContainer",
                    Uri = new Uri("https://accountname.blob.core.windows.net/containername"),
                },
                Options = { ContainerRegistryPipelineOption.OverwriteBlobs },
            };
            ArmOperation<ContainerRegistryExportPipelineResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, exportPipelineName, data);
            ContainerRegistryExportPipelineResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryExportPipelineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ExportPipelineGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/ExportPipelineGet.json
            // this example is just showing the usage of "ExportPipelines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryExportPipelineResource
            ContainerRegistryExportPipelineCollection collection = containerRegistry.GetContainerRegistryExportPipelines();

            // invoke the operation
            string exportPipelineName = "myExportPipeline";
            ContainerRegistryExportPipelineResource result = await collection.GetAsync(exportPipelineName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryExportPipelineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ExportPipelineList()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/ExportPipelineList.json
            // this example is just showing the usage of "ExportPipelines_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryExportPipelineResource
            ContainerRegistryExportPipelineCollection collection = containerRegistry.GetContainerRegistryExportPipelines();

            // invoke the operation and iterate over the result
            await foreach (ContainerRegistryExportPipelineResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerRegistryExportPipelineData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ExportPipelineGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/ExportPipelineGet.json
            // this example is just showing the usage of "ExportPipelines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryExportPipelineResource
            ContainerRegistryExportPipelineCollection collection = containerRegistry.GetContainerRegistryExportPipelines();

            // invoke the operation
            string exportPipelineName = "myExportPipeline";
            bool result = await collection.ExistsAsync(exportPipelineName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ExportPipelineGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/ExportPipelineGet.json
            // this example is just showing the usage of "ExportPipelines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryExportPipelineResource
            ContainerRegistryExportPipelineCollection collection = containerRegistry.GetContainerRegistryExportPipelines();

            // invoke the operation
            string exportPipelineName = "myExportPipeline";
            NullableResponse<ContainerRegistryExportPipelineResource> response = await collection.GetIfExistsAsync(exportPipelineName);
            ContainerRegistryExportPipelineResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerRegistryExportPipelineData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
