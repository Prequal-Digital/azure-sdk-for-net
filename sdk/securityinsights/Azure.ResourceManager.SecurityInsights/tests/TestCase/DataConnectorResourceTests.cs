﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.OperationalInsights;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.SecurityInsights.Models;
using Azure.ResourceManager.SecurityInsights.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityInsights.Tests.TestCase
{
    public class DataConnectorResourceTests : SecurityInsightsManagementTestBase
    {
        public DataConnectorResourceTests(bool isAsync)
            : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        private async Task<ResourceGroupResource> GetResourceGroupAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup;
        }

        #region Workspace
        private OperationalInsightsWorkspaceCollection GetWorkspaceCollectionAsync(ResourceGroupResource resourceGroup)
        {
            return resourceGroup.GetOperationalInsightsWorkspaces();
        }
        private async Task<OperationalInsightsWorkspaceResource> GetWorkspaceResourceAsync(ResourceGroupResource resourceGroup)
        {
            var workspaceCollection = GetWorkspaceCollectionAsync(resourceGroup);
            var workspaceName1 = groupName + "-ws";
            var workspaceInput = GetWorkspaceData();
            var lrow = await workspaceCollection.CreateOrUpdateAsync(WaitUntil.Completed, workspaceName1, workspaceInput);
            OperationalInsightsWorkspaceResource workspace = lrow.Value;
            return workspace;
        }
        #endregion
        #region Onboard
        private async Task<SecurityInsightsSentinelOnboardingStateResource> GetSentinelOnboardingStateResourceAsync(OperationalInsightsWorkspaceSecurityInsightsResource operationalInsights)
        {
            var onboardCollection = operationalInsights.GetSecurityInsightsSentinelOnboardingStates();
            var onboardName = "default";
            var onboardInput = ResourceDataHelpers.GetSentinelOnboardingStateData();
            var lroo = await onboardCollection.CreateOrUpdateAsync(WaitUntil.Completed, onboardName, onboardInput);
            SecurityInsightsSentinelOnboardingStateResource onboard1 = lroo.Value;
            return onboard1;
        }
        #endregion
        private async Task<SecurityInsightsDataConnectorResource> CreateDataConnectorAsync(OperationalInsightsWorkspaceSecurityInsightsResource operationalInsights, string dataName)
        {
            var collection = operationalInsights.GetSecurityInsightsDataConnectors();
            var input = ResourceDataHelpers.GetDataConnectorData();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataName, input);
            return lro.Value;
        }

        [TestCase]
        [Ignore("This test case will cause errors in the pipeline. After fixing the problem, restore this test")]
        public async Task DataConnectorResourceApiTests()
        {
            //0.prepare
            var resourceGroup = await GetResourceGroupAsync();
            var workspaceName = groupName + "-ws";
            var ResourceID = CreateResourceIdentifier("db1ab6f0-4769-4b27-930e-01e2ef9c123c", groupName, workspaceName);
            var operationalInsights = new OperationalInsightsWorkspaceSecurityInsightsResource(Client, ResourceID);
            var workspace = await GetWorkspaceResourceAsync(resourceGroup);
            var sOS = await GetSentinelOnboardingStateResourceAsync(operationalInsights);
            //1.Get
            var dataName = Recording.GenerateAssetName("testDataConnectors-");
            var data1 = await CreateDataConnectorAsync(operationalInsights, dataName);
            SecurityInsightsDataConnectorResource data2 = await data1.GetAsync();

            ResourceDataHelpers.AssertDataConnectorData(data1.Data, data2.Data);
            //2.Delete
            await data1.DeleteAsync(WaitUntil.Completed);
        }
    }
}
