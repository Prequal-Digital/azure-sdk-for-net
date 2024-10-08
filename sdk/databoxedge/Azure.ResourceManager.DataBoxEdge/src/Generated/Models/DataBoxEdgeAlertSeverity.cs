// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Severity of the alert. </summary>
    public readonly partial struct DataBoxEdgeAlertSeverity : IEquatable<DataBoxEdgeAlertSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeAlertSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeAlertSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InformationalValue = "Informational";
        private const string WarningValue = "Warning";
        private const string CriticalValue = "Critical";

        /// <summary> Informational. </summary>
        public static DataBoxEdgeAlertSeverity Informational { get; } = new DataBoxEdgeAlertSeverity(InformationalValue);
        /// <summary> Warning. </summary>
        public static DataBoxEdgeAlertSeverity Warning { get; } = new DataBoxEdgeAlertSeverity(WarningValue);
        /// <summary> Critical. </summary>
        public static DataBoxEdgeAlertSeverity Critical { get; } = new DataBoxEdgeAlertSeverity(CriticalValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeAlertSeverity"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeAlertSeverity left, DataBoxEdgeAlertSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeAlertSeverity"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeAlertSeverity left, DataBoxEdgeAlertSeverity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataBoxEdgeAlertSeverity"/>. </summary>
        public static implicit operator DataBoxEdgeAlertSeverity(string value) => new DataBoxEdgeAlertSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeAlertSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeAlertSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
