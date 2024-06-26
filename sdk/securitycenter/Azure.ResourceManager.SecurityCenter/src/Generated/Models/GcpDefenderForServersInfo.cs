// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Defender for servers connection configuration. </summary>
    public partial class GcpDefenderForServersInfo
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

        /// <summary> Initializes a new instance of <see cref="GcpDefenderForServersInfo"/>. </summary>
        public GcpDefenderForServersInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GcpDefenderForServersInfo"/>. </summary>
        /// <param name="workloadIdentityProviderId"> The workload identity provider id in GCP for this feature. </param>
        /// <param name="serviceAccountEmailAddress"> The service account email address in GCP for this feature. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GcpDefenderForServersInfo(string workloadIdentityProviderId, string serviceAccountEmailAddress, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            WorkloadIdentityProviderId = workloadIdentityProviderId;
            ServiceAccountEmailAddress = serviceAccountEmailAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The workload identity provider id in GCP for this feature. </summary>
        public string WorkloadIdentityProviderId { get; set; }
        /// <summary> The service account email address in GCP for this feature. </summary>
        public string ServiceAccountEmailAddress { get; set; }
    }
}
