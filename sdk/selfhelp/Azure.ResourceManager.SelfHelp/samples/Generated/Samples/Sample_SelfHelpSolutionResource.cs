// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SelfHelp.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SelfHelp.Samples
{
    public partial class Sample_SelfHelpSolutionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SolutionGet()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/preview/2024-03-01-preview/examples/Solution_Get.json
            // this example is just showing the usage of "Solution_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SelfHelpSolutionResource created on azure
            // for more information of creating SelfHelpSolutionResource, please refer to the document of SelfHelpSolutionResource
            string scope = "subscriptions/mySubscription/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-rp";
            string solutionResourceName = "SolutionResource1";
            ResourceIdentifier selfHelpSolutionResourceId = SelfHelpSolutionResource.CreateResourceIdentifier(scope, solutionResourceName);
            SelfHelpSolutionResource selfHelpSolution = client.GetSelfHelpSolutionResource(selfHelpSolutionResourceId);

            // invoke the operation
            SelfHelpSolutionResource result = await selfHelpSolution.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SelfHelpSolutionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SolutionUpdate()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/preview/2024-03-01-preview/examples/Solution_Update.json
            // this example is just showing the usage of "Solution_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SelfHelpSolutionResource created on azure
            // for more information of creating SelfHelpSolutionResource, please refer to the document of SelfHelpSolutionResource
            string scope = "subscriptions/mySubscription/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-rp";
            string solutionResourceName = "SolutionResourceName1";
            ResourceIdentifier selfHelpSolutionResourceId = SelfHelpSolutionResource.CreateResourceIdentifier(scope, solutionResourceName);
            SelfHelpSolutionResource selfHelpSolution = client.GetSelfHelpSolutionResource(selfHelpSolutionResourceId);

            // invoke the operation
            SelfHelpSolutionPatch patch = new SelfHelpSolutionPatch();
            ArmOperation<SelfHelpSolutionResource> lro = await selfHelpSolution.UpdateAsync(WaitUntil.Completed, patch);
            SelfHelpSolutionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SelfHelpSolutionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task WarmUp_SolutionWarmUp()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/preview/2024-03-01-preview/examples/Solution_WarmUp.json
            // this example is just showing the usage of "Solution_WarmUp" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SelfHelpSolutionResource created on azure
            // for more information of creating SelfHelpSolutionResource, please refer to the document of SelfHelpSolutionResource
            string scope = "subscriptions/mySubscription/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-rp";
            string solutionResourceName = "SolutionResourceName1";
            ResourceIdentifier selfHelpSolutionResourceId = SelfHelpSolutionResource.CreateResourceIdentifier(scope, solutionResourceName);
            SelfHelpSolutionResource selfHelpSolution = client.GetSelfHelpSolutionResource(selfHelpSolutionResourceId);

            // invoke the operation
            await selfHelpSolution.WarmUpAsync();

            Console.WriteLine("Succeeded");
        }
    }
}
