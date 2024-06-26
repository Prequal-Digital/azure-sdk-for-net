// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The schedule associated with the export. </summary>
    public partial class ExportSchedule
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

        /// <summary> Initializes a new instance of <see cref="ExportSchedule"/>. </summary>
        public ExportSchedule()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExportSchedule"/>. </summary>
        /// <param name="status"> The status of the export's schedule. If 'Inactive', the export's schedule is paused. </param>
        /// <param name="recurrence"> The schedule recurrence. </param>
        /// <param name="recurrencePeriod"> Has start and end date of the recurrence. The start date must be in future. If present, the end date must be greater than start date. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportSchedule(ExportScheduleStatusType? status, ExportScheduleRecurrenceType? recurrence, ExportRecurrencePeriod recurrencePeriod, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Recurrence = recurrence;
            RecurrencePeriod = recurrencePeriod;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status of the export's schedule. If 'Inactive', the export's schedule is paused. </summary>
        public ExportScheduleStatusType? Status { get; set; }
        /// <summary> The schedule recurrence. </summary>
        public ExportScheduleRecurrenceType? Recurrence { get; set; }
        /// <summary> Has start and end date of the recurrence. The start date must be in future. If present, the end date must be greater than start date. </summary>
        public ExportRecurrencePeriod RecurrencePeriod { get; set; }
    }
}
