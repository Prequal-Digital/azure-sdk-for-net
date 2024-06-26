// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Properties for a CVE analysis summary. </summary>
    public partial class CveSummary : FirmwareAnalysisSummaryProperties
    {
        /// <summary> Initializes a new instance of <see cref="CveSummary"/>. </summary>
        internal CveSummary()
        {
            SummaryType = FirmwareAnalysisSummaryType.Cve;
        }

        /// <summary> Initializes a new instance of <see cref="CveSummary"/>. </summary>
        /// <param name="summaryType"> Describes the type of summary. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="critical"> The total number of critical severity CVEs detected. </param>
        /// <param name="high"> The total number of high severity CVEs detected. </param>
        /// <param name="medium"> The total number of medium severity CVEs detected. </param>
        /// <param name="low"> The total number of low severity CVEs detected. </param>
        /// <param name="unknown"> The total number of unknown severity CVEs detected. </param>
        internal CveSummary(FirmwareAnalysisSummaryType summaryType, IDictionary<string, BinaryData> serializedAdditionalRawData, long? critical, long? high, long? medium, long? low, long? unknown) : base(summaryType, serializedAdditionalRawData)
        {
            Critical = critical;
            High = high;
            Medium = medium;
            Low = low;
            Unknown = unknown;
            SummaryType = summaryType;
        }

        /// <summary> The total number of critical severity CVEs detected. </summary>
        public long? Critical { get; }
        /// <summary> The total number of high severity CVEs detected. </summary>
        public long? High { get; }
        /// <summary> The total number of medium severity CVEs detected. </summary>
        public long? Medium { get; }
        /// <summary> The total number of low severity CVEs detected. </summary>
        public long? Low { get; }
        /// <summary> The total number of unknown severity CVEs detected. </summary>
        public long? Unknown { get; }
    }
}
