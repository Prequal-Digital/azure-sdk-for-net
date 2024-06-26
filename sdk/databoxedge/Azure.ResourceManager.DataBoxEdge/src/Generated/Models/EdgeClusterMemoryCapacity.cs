// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> NodeCapacityInfo defines the required information to determine the placement of a VM. </summary>
    public partial class EdgeClusterMemoryCapacity
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EdgeClusterMemoryCapacity"/>. </summary>
        public EdgeClusterMemoryCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EdgeClusterMemoryCapacity"/>. </summary>
        /// <param name="clusterFreeMemoryInMB"> The free memory in the cluster in MB. </param>
        /// <param name="clusterUsedMemoryInMB"> The used memory in the cluster in MB. </param>
        /// <param name="clusterFailoverMemoryInMB"> The failover memory in the cluster in MB. </param>
        /// <param name="clusterFragmentationMemoryInMB"> The fragmentation memory in the cluster in MB. </param>
        /// <param name="clusterHyperVReserveMemoryMb"> The memory reserved for Hyper-V in the cluster in MB. </param>
        /// <param name="clusterInfraVmMemoryInMB"> The memory of the Infra VM in the cluster in MB. </param>
        /// <param name="clusterTotalMemoryInMB"> The total memory in the cluster in MB. </param>
        /// <param name="clusterNonFailoverVmInMB"> The non-failover memory in the cluster in MB. </param>
        /// <param name="clusterMemoryUsedByVmsInMB"> The memory used by VMs in the cluster in MB. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeClusterMemoryCapacity(double? clusterFreeMemoryInMB, double? clusterUsedMemoryInMB, double? clusterFailoverMemoryInMB, double? clusterFragmentationMemoryInMB, double? clusterHyperVReserveMemoryMb, double? clusterInfraVmMemoryInMB, double? clusterTotalMemoryInMB, double? clusterNonFailoverVmInMB, double? clusterMemoryUsedByVmsInMB, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClusterFreeMemoryInMB = clusterFreeMemoryInMB;
            ClusterUsedMemoryInMB = clusterUsedMemoryInMB;
            ClusterFailoverMemoryInMB = clusterFailoverMemoryInMB;
            ClusterFragmentationMemoryInMB = clusterFragmentationMemoryInMB;
            ClusterHyperVReserveMemoryMb = clusterHyperVReserveMemoryMb;
            ClusterInfraVmMemoryInMB = clusterInfraVmMemoryInMB;
            ClusterTotalMemoryInMB = clusterTotalMemoryInMB;
            ClusterNonFailoverVmInMB = clusterNonFailoverVmInMB;
            ClusterMemoryUsedByVmsInMB = clusterMemoryUsedByVmsInMB;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The free memory in the cluster in MB. </summary>
        public double? ClusterFreeMemoryInMB { get; set; }
        /// <summary> The used memory in the cluster in MB. </summary>
        public double? ClusterUsedMemoryInMB { get; set; }
        /// <summary> The failover memory in the cluster in MB. </summary>
        public double? ClusterFailoverMemoryInMB { get; set; }
        /// <summary> The fragmentation memory in the cluster in MB. </summary>
        public double? ClusterFragmentationMemoryInMB { get; set; }
        /// <summary> The memory reserved for Hyper-V in the cluster in MB. </summary>
        public double? ClusterHyperVReserveMemoryMb { get; set; }
        /// <summary> The memory of the Infra VM in the cluster in MB. </summary>
        public double? ClusterInfraVmMemoryInMB { get; set; }
        /// <summary> The total memory in the cluster in MB. </summary>
        public double? ClusterTotalMemoryInMB { get; set; }
        /// <summary> The non-failover memory in the cluster in MB. </summary>
        public double? ClusterNonFailoverVmInMB { get; set; }
        /// <summary> The memory used by VMs in the cluster in MB. </summary>
        public double? ClusterMemoryUsedByVmsInMB { get; set; }
    }
}
