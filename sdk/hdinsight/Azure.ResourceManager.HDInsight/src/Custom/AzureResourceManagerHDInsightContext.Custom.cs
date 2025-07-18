// <auto-generated/>

using Azure.ResourceManager.HDInsight;
using Azure.ResourceManager.HDInsight.Models;
using System.ClientModel.Primitives;

namespace Azure.ResourceManager.HDInsight;

[ModelReaderWriterBuildable(typeof(HDInsightApplicationData))]
[ModelReaderWriterBuildable(typeof(HDInsightApplicationResource))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterData))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterResource))]
[ModelReaderWriterBuildable(typeof(HDInsightPrivateEndpointConnectionData))]
[ModelReaderWriterBuildable(typeof(HDInsightPrivateEndpointConnectionResource))]
[ModelReaderWriterBuildable(typeof(HDInsightPrivateLinkResource))]
[ModelReaderWriterBuildable(typeof(HDInsightPrivateLinkResourceData))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterGatewaySettings))]
[ModelReaderWriterBuildable(typeof(ApplicationListResult))]
[ModelReaderWriterBuildable(typeof(ClientGroupInfo))]
[ModelReaderWriterBuildable(typeof(ClusterListResult))]
[ModelReaderWriterBuildable(typeof(ComputeProfile))]
[ModelReaderWriterBuildable(typeof(ConnectivityEndpoint))]
[ModelReaderWriterBuildable(typeof(EncryptionInTransitProperties))]
[ModelReaderWriterBuildable(typeof(EntraUserInfo))]
[ModelReaderWriterBuildable(typeof(ExcludedServicesConfig))]
[ModelReaderWriterBuildable(typeof(ExecuteScriptActionContent))]
[ModelReaderWriterBuildable(typeof(HardwareProfile))]
[ModelReaderWriterBuildable(typeof(HDInsightApplicationEndpoint))]
[ModelReaderWriterBuildable(typeof(HDInsightApplicationHttpsEndpoint))]
[ModelReaderWriterBuildable(typeof(HDInsightApplicationProperties))]
[ModelReaderWriterBuildable(typeof(HDInsightAsyncOperationResult))]
[ModelReaderWriterBuildable(typeof(HDInsightAutoScaleCapacity))]
[ModelReaderWriterBuildable(typeof(HDInsightAutoScaleConfiguration))]
[ModelReaderWriterBuildable(typeof(HDInsightAutoScaleConfigurationUpdateContent))]
[ModelReaderWriterBuildable(typeof(HDInsightAutoScaleRecurrence))]
[ModelReaderWriterBuildable(typeof(HDInsightAutoScaleSchedule))]
[ModelReaderWriterBuildable(typeof(HDInsightAutoScaleTimeAndCapacity))]
[ModelReaderWriterBuildable(typeof(HDInsightAzureMonitorExtensionEnableContent))]
[ModelReaderWriterBuildable(typeof(HDInsightAzureMonitorExtensionStatus))]
[ModelReaderWriterBuildable(typeof(HDInsightAzureMonitorSelectedConfigurations))]
[ModelReaderWriterBuildable(typeof(HDInsightAzureMonitorTableConfiguration))]
[ModelReaderWriterBuildable(typeof(HDInsightBillingMeters))]
[ModelReaderWriterBuildable(typeof(HDInsightBillingResources))]
[ModelReaderWriterBuildable(typeof(HDInsightBillingSpecsListResult))]
[ModelReaderWriterBuildable(typeof(HDInsightCapabilitiesResult))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterAaddsDetail))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterConfigurations))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterCreateExtensionContent))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterCreateOrUpdateContent))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterCreateOrUpdateProperties))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterCreationValidateContent))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterCreationValidateResult))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterDataDiskGroup))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterDefinition))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterDiskEncryptionContent))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterEnableClusterMonitoringContent))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterExtensionStatus))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterHostInfo))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterIPTag))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterNetworkProperties))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterPatch))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterProperties))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterResizeContent))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterRole))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterUpdateGatewaySettingsContent))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterUpdateIdentityCertificateContent))]
[ModelReaderWriterBuildable(typeof(HDInsightClusterValidationErrorInfo))]
[ModelReaderWriterBuildable(typeof(HDInsightComputeIsolationProperties))]
[ModelReaderWriterBuildable(typeof(HDInsightDiskBillingMeters))]
[ModelReaderWriterBuildable(typeof(HDInsightDiskEncryptionProperties))]
[ModelReaderWriterBuildable(typeof(HDInsightIPConfiguration))]
[ModelReaderWriterBuildable(typeof(HDInsightLinuxOSProfile))]
[ModelReaderWriterBuildable(typeof(HDInsightLocalizedName))]
[ModelReaderWriterBuildable(typeof(HDInsightNameAvailabilityContent))]
[ModelReaderWriterBuildable(typeof(HDInsightNameAvailabilityResult))]
[ModelReaderWriterBuildable(typeof(HDInsightPrivateEndpointConnectionListResult))]
[ModelReaderWriterBuildable(typeof(HDInsightPrivateLinkConfiguration))]
[ModelReaderWriterBuildable(typeof(HDInsightPrivateLinkResourceListResult))]
[ModelReaderWriterBuildable(typeof(HDInsightPrivateLinkServiceConnectionState))]
[ModelReaderWriterBuildable(typeof(HDInsightSecurityProfile))]
[ModelReaderWriterBuildable(typeof(HDInsightSshPublicKey))]
[ModelReaderWriterBuildable(typeof(HDInsightStorageAccountInfo))]
[ModelReaderWriterBuildable(typeof(HDInsightUsage))]
[ModelReaderWriterBuildable(typeof(HDInsightVersionsCapability))]
[ModelReaderWriterBuildable(typeof(HDInsightVersionSpec))]
[ModelReaderWriterBuildable(typeof(HDInsightVirtualNetworkProfile))]
[ModelReaderWriterBuildable(typeof(HDInsightVmSizeCompatibilityFilterV2))]
[ModelReaderWriterBuildable(typeof(HDInsightVmSizeProperty))]
[ModelReaderWriterBuildable(typeof(KafkaRestProperties))]
[ModelReaderWriterBuildable(typeof(OSProfile))]
[ModelReaderWriterBuildable(typeof(QuotaCapability))]
[ModelReaderWriterBuildable(typeof(QuotaInfo))]
[ModelReaderWriterBuildable(typeof(RegionalQuotaCapability))]
[ModelReaderWriterBuildable(typeof(RegionsCapability))]
[ModelReaderWriterBuildable(typeof(RuntimeScriptAction))]
[ModelReaderWriterBuildable(typeof(RuntimeScriptActionDetail))]
[ModelReaderWriterBuildable(typeof(ScriptAction))]
[ModelReaderWriterBuildable(typeof(ScriptActionExecutionHistoryList))]
[ModelReaderWriterBuildable(typeof(ScriptActionExecutionSummary))]
[ModelReaderWriterBuildable(typeof(ScriptActionsList))]
[ModelReaderWriterBuildable(typeof(SshProfile))]
[ModelReaderWriterBuildable(typeof(StorageProfile))]
[ModelReaderWriterBuildable(typeof(UsagesListResult))]
public partial class AzureResourceManagerHDInsightContext
{
}
