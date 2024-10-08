// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> If update State is HasPrerequisite, this property contains an array of objects describing prerequisite updates before installing this update. Otherwise, it is empty. </summary>
    [Obsolete("This class is now deprecated. Please use the new class `HciClusterUpdatePrerequisite` moving forward.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class UpdatePrerequisite
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

        /// <summary> Initializes a new instance of <see cref="UpdatePrerequisite"/>. </summary>
        public UpdatePrerequisite()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpdatePrerequisite"/>. </summary>
        /// <param name="updateType"> Updatable component type. </param>
        /// <param name="version"> Version of the prerequisite. </param>
        /// <param name="packageName"> Friendly name of the prerequisite. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdatePrerequisite(string updateType, string version, string packageName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UpdateType = updateType;
            Version = version;
            PackageName = packageName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal UpdatePrerequisite(HciClusterUpdatePrerequisite data)
        {
            UpdateType = data.UpdateType;
            Version = data.Version;
            PackageName = data.PackageName;
            _serializedAdditionalRawData = null;
        }

        internal HciClusterUpdatePrerequisite ToHciClusterUpdatePrerequisite()
        {
            return new HciClusterUpdatePrerequisite(UpdateType, Version, PackageName, null);
        }
        /// <summary> Updatable component type. </summary>
        public string UpdateType { get; set; }
        /// <summary> Version of the prerequisite. </summary>
        public string Version { get; set; }
        /// <summary> Friendly name of the prerequisite. </summary>
        public string PackageName { get; set; }
    }
}
