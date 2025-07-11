// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> Predefined configurations for the file system. </summary>
    public partial class DefinedFileSystemConfiguration
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

        /// <summary> Initializes a new instance of <see cref="DefinedFileSystemConfiguration"/>. </summary>
        internal DefinedFileSystemConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefinedFileSystemConfiguration"/>. </summary>
        /// <param name="isBackupPartition"> Checks if the data can be backed up. </param>
        /// <param name="isResizable"> Checks if the mount path is resizable. </param>
        /// <param name="minSizeGb"> Minimum size of mount path in Gb. </param>
        /// <param name="mountPoint"> Mount path for the file system. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DefinedFileSystemConfiguration(bool? isBackupPartition, bool? isResizable, int? minSizeGb, string mountPoint, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsBackupPartition = isBackupPartition;
            IsResizable = isResizable;
            MinSizeGb = minSizeGb;
            MountPoint = mountPoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Checks if the data can be backed up. </summary>
        public bool? IsBackupPartition { get; }
        /// <summary> Checks if the mount path is resizable. </summary>
        public bool? IsResizable { get; }
        /// <summary> Minimum size of mount path in Gb. </summary>
        public int? MinSizeGb { get; }
        /// <summary> Mount path for the file system. </summary>
        public string MountPoint { get; }
    }
}
