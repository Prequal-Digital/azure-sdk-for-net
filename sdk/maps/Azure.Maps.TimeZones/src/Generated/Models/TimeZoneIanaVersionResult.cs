// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.TimeZones
{
    /// <summary> This object is returned from a successful Timezone IANA Version call. </summary>
    public partial class TimeZoneIanaVersionResult
    {
        /// <summary> Initializes a new instance of <see cref="TimeZoneIanaVersionResult"/>. </summary>
        internal TimeZoneIanaVersionResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TimeZoneIanaVersionResult"/>. </summary>
        /// <param name="version"> Version property. </param>
        internal TimeZoneIanaVersionResult(string version)
        {
            Version = version;
        }

        /// <summary> Version property. </summary>
        public string Version { get; }
    }
}
