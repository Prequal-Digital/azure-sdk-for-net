// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StreamAnalytics.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.StreamAnalytics.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetStreamingJobs_ListAllStreamingJobsInASubscriptionAndDoNotUseTheExpandODataQueryParameter()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_List_BySubscription_NoExpand.json
            // this example is just showing the usage of "StreamingJobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (StreamingJobResource item in subscriptionResource.GetStreamingJobsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamingJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetStreamingJobs_ListAllStreamingJobsInASubscriptionAndUseTheExpandODataQueryParameterToExpandInputsOutputsTransformationAndFunctions()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_List_BySubscription_Expand.json
            // this example is just showing the usage of "StreamingJobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            string expand = "inputs,outputs,transformation,functions";
            await foreach (StreamingJobResource item in subscriptionResource.GetStreamingJobsAsync(expand: expand))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamingJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetQuotasSubscriptions_ListSubscriptionQuotaInformationInWestUS()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Subscription_ListQuotas.json
            // this example is just showing the usage of "Subscriptions_ListQuotas" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("West US");
            await foreach (StreamAnalyticsSubscriptionQuota item in subscriptionResource.GetQuotasSubscriptionsAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task TestQuerySubscription_TestTheStreamAnalyticsQuery()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Subscription_TestQuery.json
            // this example is just showing the usage of "Subscriptions_TestQuery" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("West US");
            StreamAnalyticsTestQuery testQuery = new StreamAnalyticsTestQuery(new StreamingJobData(new AzureLocation("West US"))
            {
                SkuName = StreamAnalyticsSkuName.Standard,
                EventsOutOfOrderPolicy = EventsOutOfOrderPolicy.Drop,
                OutputErrorPolicy = StreamingJobOutputErrorPolicy.Drop,
                EventsOutOfOrderMaxDelayInSeconds = 0,
                EventsLateArrivalMaxDelayInSeconds = 5,
                DataLocalion = new AzureLocation("en-US"),
                CompatibilityLevel = StreamingJobCompatibilityLevel.Level1_0,
                Inputs = {new StreamingJobInputData
{
Properties = new StreamInputProperties
{
Datasource = new RawStreamInputDataSource
{
PayloadUri = new Uri("http://myinput.com"),
},
Serialization = new JsonFormatSerialization
{
Encoding = StreamAnalyticsDataSerializationEncoding.Utf8,
},
},
Name = "inputtest",
}},
                Transformation = new StreamingJobTransformationData
                {
                    StreamingUnits = 1,
                    Query = "Select Id, Name from inputtest",
                    Name = "transformationtest",
                },
                Outputs = {new StreamingJobOutputData
{
Datasource = new RawOutputDatasource
{
PayloadUri = new Uri("http://myoutput.com"),
},
Serialization = new JsonFormatSerialization(),
Name = "outputtest",
}},
                Functions = { },
                Tags =
{
["key1"] = "value1",
["key3"] = "value3",
["randomKey"] = "randomValue"
},
            })
            {
                WriteUri = new Uri("http://myoutput.com"),
                Path = "/pathto/subdirectory",
            };
            ArmOperation<StreamAnalyticsQueryTestingResult> lro = await subscriptionResource.TestQuerySubscriptionAsync(WaitUntil.Completed, location, testQuery);
            StreamAnalyticsQueryTestingResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CompileQuerySubscription_CompileTheStreamAnalyticsQuery()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Subscription_CompileQuery.json
            // this example is just showing the usage of "Subscriptions_CompileQuery" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("West US");
            StreamAnalyticsCompileQuery compileQuery = new StreamAnalyticsCompileQuery("SELECT\r\n    *\r\nINTO\r\n    [output1]\r\nFROM\r\n    [input1]", StreamingJobType.Cloud)
            {
                Inputs = { new StreamAnalyticsQueryInput("input1", "Stream") },
                Functions = {new StreamAnalyticsQueryFunction("function1", "Scalar", "Microsoft.StreamAnalytics/JavascriptUdf", new StreamingJobFunctionInput[]
{
new StreamingJobFunctionInput
{
DataType = "any",
IsConfigurationParameter = default,
}
}, new StreamingJobFunctionOutput
{
DataType = "bigint",
})},
                CompatibilityLevel = StreamingJobCompatibilityLevel.Level1_2,
            };
            StreamAnalyticsQueryCompilationResult result = await subscriptionResource.CompileQuerySubscriptionAsync(location, compileQuery);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task SampleInputSubscription_SampleTheStreamAnalyticsInputData()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Subscription_SampleInput.json
            // this example is just showing the usage of "Subscriptions_SampleInput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("West US");
            StreamAnalyticsSampleInputContent content = new StreamAnalyticsSampleInputContent
            {
                Input = new StreamingJobInputData
                {
                    Properties = new StreamInputProperties
                    {
                        Datasource = new BlobStreamInputDataSource
                        {
                            StorageAccounts = {new StreamAnalyticsStorageAccount
{
AccountName = "someAccountName",
AccountKey = "someAccountKey==",
}},
                            Container = "state",
                            PathPattern = "{date}/{time}",
                            DateFormat = "yyyy/MM/dd",
                            TimeFormat = "HH",
                            SourcePartitionCount = 16,
                        },
                        Serialization = new CsvFormatSerialization
                        {
                            FieldDelimiter = ",",
                            Encoding = StreamAnalyticsDataSerializationEncoding.Utf8,
                        },
                    },
                },
                CompatibilityLevel = "1.2",
                EventsUri = new Uri("http://myoutput.com"),
                DataLocalion = new AzureLocation("en-US"),
            };
            ArmOperation<StreamAnalyticsSampleInputResult> lro = await subscriptionResource.SampleInputSubscriptionAsync(WaitUntil.Completed, location, content);
            StreamAnalyticsSampleInputResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task TestInputSubscription_TestTheStreamAnalyticsInput()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Subscription_TestInput.json
            // this example is just showing the usage of "Subscriptions_TestInput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("West US");
            StreamAnalyticsTestContent content = new StreamAnalyticsTestContent(new StreamingJobInputData
            {
                Properties = new StreamInputProperties
                {
                    Datasource = new BlobStreamInputDataSource
                    {
                        StorageAccounts = {new StreamAnalyticsStorageAccount
{
AccountName = "someAccountName",
AccountKey = "someAccountKey==",
}},
                        Container = "state",
                        PathPattern = "{date}/{time}",
                        DateFormat = "yyyy/MM/dd",
                        TimeFormat = "HH",
                        SourcePartitionCount = 16,
                    },
                    Serialization = new CsvFormatSerialization
                    {
                        FieldDelimiter = ",",
                        Encoding = StreamAnalyticsDataSerializationEncoding.Utf8,
                    },
                },
            });
            ArmOperation<StreamAnalyticsTestDatasourceResult> lro = await subscriptionResource.TestInputSubscriptionAsync(WaitUntil.Completed, location, content);
            StreamAnalyticsTestDatasourceResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task TestOutputSubscription_TestTheStreamAnalyticsOutput()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Subscription_TestOutput.json
            // this example is just showing the usage of "Subscriptions_TestOutput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("West US");
            StreamAnalyticsTestOutput testOutput = new StreamAnalyticsTestOutput(new StreamingJobOutputData
            {
                Datasource = new BlobOutputDataSource
                {
                    StorageAccounts = {new StreamAnalyticsStorageAccount
{
AccountName = "someAccountName",
AccountKey = "accountKey==",
}},
                    Container = "state",
                    PathPattern = "{date}/{time}",
                    DateFormat = "yyyy/MM/dd",
                    TimeFormat = "HH",
                },
                Serialization = new CsvFormatSerialization
                {
                    FieldDelimiter = ",",
                    Encoding = StreamAnalyticsDataSerializationEncoding.Utf8,
                },
            });
            ArmOperation<StreamAnalyticsTestDatasourceResult> lro = await subscriptionResource.TestOutputSubscriptionAsync(WaitUntil.Completed, location, testOutput);
            StreamAnalyticsTestDatasourceResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetStreamAnalyticsClusters_ListTheClustersInASubscription()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2020-03-01-preview/examples/Cluster_ListBySubscription.json
            // this example is just showing the usage of "Clusters_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (StreamAnalyticsClusterResource item in subscriptionResource.GetStreamAnalyticsClustersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamAnalyticsClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
