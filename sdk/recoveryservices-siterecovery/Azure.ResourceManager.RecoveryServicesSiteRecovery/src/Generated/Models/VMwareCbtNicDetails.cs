// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt NIC details. </summary>
    public partial class VMwareCbtNicDetails
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

        /// <summary> Initializes a new instance of <see cref="VMwareCbtNicDetails"/>. </summary>
        internal VMwareCbtNicDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtNicDetails"/>. </summary>
        /// <param name="nicId"> The NIC Id. </param>
        /// <param name="isPrimaryNic"> A value indicating whether this is the primary NIC. </param>
        /// <param name="sourceIPAddress"> The source IP address. </param>
        /// <param name="sourceIPAddressType"> The source IP address type. </param>
        /// <param name="sourceNetworkId"> Source network Id. </param>
        /// <param name="targetIPAddress"> The target IP address. </param>
        /// <param name="targetIPAddressType"> The target IP address type. </param>
        /// <param name="targetSubnetName"> Target subnet name. </param>
        /// <param name="testNetworkId"> Source network Id. </param>
        /// <param name="testSubnetName"> Test subnet name. </param>
        /// <param name="testIPAddress"> The test IP address. </param>
        /// <param name="testIPAddressType"> The test IP address type. </param>
        /// <param name="targetNicName"> Target NIC name. </param>
        /// <param name="isSelectedForMigration"> A value indicating whether this NIC is selected for migration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VMwareCbtNicDetails(string nicId, string isPrimaryNic, IPAddress sourceIPAddress, SiteRecoveryEthernetAddressType? sourceIPAddressType, ResourceIdentifier sourceNetworkId, IPAddress targetIPAddress, SiteRecoveryEthernetAddressType? targetIPAddressType, string targetSubnetName, ResourceIdentifier testNetworkId, string testSubnetName, IPAddress testIPAddress, SiteRecoveryEthernetAddressType? testIPAddressType, string targetNicName, string isSelectedForMigration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NicId = nicId;
            IsPrimaryNic = isPrimaryNic;
            SourceIPAddress = sourceIPAddress;
            SourceIPAddressType = sourceIPAddressType;
            SourceNetworkId = sourceNetworkId;
            TargetIPAddress = targetIPAddress;
            TargetIPAddressType = targetIPAddressType;
            TargetSubnetName = targetSubnetName;
            TestNetworkId = testNetworkId;
            TestSubnetName = testSubnetName;
            TestIPAddress = testIPAddress;
            TestIPAddressType = testIPAddressType;
            TargetNicName = targetNicName;
            IsSelectedForMigration = isSelectedForMigration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The NIC Id. </summary>
        public string NicId { get; }
        /// <summary> A value indicating whether this is the primary NIC. </summary>
        public string IsPrimaryNic { get; }
        /// <summary> The source IP address. </summary>
        public IPAddress SourceIPAddress { get; }
        /// <summary> The source IP address type. </summary>
        public SiteRecoveryEthernetAddressType? SourceIPAddressType { get; }
        /// <summary> Source network Id. </summary>
        public ResourceIdentifier SourceNetworkId { get; }
        /// <summary> The target IP address. </summary>
        public IPAddress TargetIPAddress { get; }
        /// <summary> The target IP address type. </summary>
        public SiteRecoveryEthernetAddressType? TargetIPAddressType { get; }
        /// <summary> Target subnet name. </summary>
        public string TargetSubnetName { get; }
        /// <summary> Source network Id. </summary>
        public ResourceIdentifier TestNetworkId { get; }
        /// <summary> Test subnet name. </summary>
        public string TestSubnetName { get; }
        /// <summary> The test IP address. </summary>
        public IPAddress TestIPAddress { get; }
        /// <summary> The test IP address type. </summary>
        public SiteRecoveryEthernetAddressType? TestIPAddressType { get; }
        /// <summary> Target NIC name. </summary>
        public string TargetNicName { get; }
        /// <summary> A value indicating whether this NIC is selected for migration. </summary>
        public string IsSelectedForMigration { get; }
    }
}
