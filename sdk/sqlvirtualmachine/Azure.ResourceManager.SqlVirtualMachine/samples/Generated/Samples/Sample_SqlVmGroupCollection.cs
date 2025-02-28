// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SqlVirtualMachine.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SqlVirtualMachine.Samples
{
    public partial class Sample_SqlVmGroupCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesOrUpdatesASQLVirtualMachineGroup()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/CreateOrUpdateSqlVirtualMachineGroup.json
            // this example is just showing the usage of "SqlVirtualMachineGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmGroupResource
            SqlVmGroupCollection collection = resourceGroupResource.GetSqlVmGroups();

            // invoke the operation
            string sqlVmGroupName = "testvmgroup";
            SqlVmGroupData data = new SqlVmGroupData(new AzureLocation("northeurope"))
            {
                SqlImageOffer = "SQL2016-WS2016",
                SqlImageSku = SqlVmGroupImageSku.Enterprise,
                WindowsServerFailoverClusterDomainProfile = new WindowsServerFailoverClusterDomainProfile
                {
                    DomainFqdn = "testdomain.com",
                    OrganizationalUnitPath = "OU=WSCluster,DC=testdomain,DC=com",
                    ClusterBootstrapAccount = "testrpadmin",
                    ClusterOperatorAccount = "testrp@testdomain.com",
                    SqlServiceAccount = "sqlservice@testdomain.com",
                    StorageAccountUri = new Uri("https://storgact.blob.core.windows.net/"),
                    StorageAccountPrimaryKey = "<primary storage access key>",
                    ClusterSubnetType = SqlVmClusterSubnetType.MultiSubnet,
                },
                Tags =
{
["mytag"] = "myval"
},
            };
            ArmOperation<SqlVmGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sqlVmGroupName, data);
            SqlVmGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlVmGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsASQLVirtualMachineGroup()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/GetSqlVirtualMachineGroup.json
            // this example is just showing the usage of "SqlVirtualMachineGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmGroupResource
            SqlVmGroupCollection collection = resourceGroupResource.GetSqlVmGroups();

            // invoke the operation
            string sqlVmGroupName = "testvmgroup";
            SqlVmGroupResource result = await collection.GetAsync(sqlVmGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlVmGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetsAllSQLVirtualMachineGroupsInAResourceGroup()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/ListByResourceGroupSqlVirtualMachineGroup.json
            // this example is just showing the usage of "SqlVirtualMachineGroups_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmGroupResource
            SqlVmGroupCollection collection = resourceGroupResource.GetSqlVmGroups();

            // invoke the operation and iterate over the result
            await foreach (SqlVmGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlVmGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsASQLVirtualMachineGroup()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/GetSqlVirtualMachineGroup.json
            // this example is just showing the usage of "SqlVirtualMachineGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmGroupResource
            SqlVmGroupCollection collection = resourceGroupResource.GetSqlVmGroups();

            // invoke the operation
            string sqlVmGroupName = "testvmgroup";
            bool result = await collection.ExistsAsync(sqlVmGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsASQLVirtualMachineGroup()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/GetSqlVirtualMachineGroup.json
            // this example is just showing the usage of "SqlVirtualMachineGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmGroupResource
            SqlVmGroupCollection collection = resourceGroupResource.GetSqlVmGroups();

            // invoke the operation
            string sqlVmGroupName = "testvmgroup";
            NullableResponse<SqlVmGroupResource> response = await collection.GetIfExistsAsync(sqlVmGroupName);
            SqlVmGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlVmGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
