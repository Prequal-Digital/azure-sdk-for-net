// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The DataAvailabilityStatus. </summary>
    public readonly partial struct DataAvailabilityStatus : IEquatable<DataAvailabilityStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataAvailabilityStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataAvailabilityStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string PendingValue = "Pending";
        private const string IncompleteValue = "Incomplete";
        private const string CompleteValue = "Complete";

        /// <summary> None. </summary>
        public static DataAvailabilityStatus None { get; } = new DataAvailabilityStatus(NoneValue);
        /// <summary> Pending. </summary>
        public static DataAvailabilityStatus Pending { get; } = new DataAvailabilityStatus(PendingValue);
        /// <summary> Incomplete. </summary>
        public static DataAvailabilityStatus Incomplete { get; } = new DataAvailabilityStatus(IncompleteValue);
        /// <summary> Complete. </summary>
        public static DataAvailabilityStatus Complete { get; } = new DataAvailabilityStatus(CompleteValue);
        /// <summary> Determines if two <see cref="DataAvailabilityStatus"/> values are the same. </summary>
        public static bool operator ==(DataAvailabilityStatus left, DataAvailabilityStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataAvailabilityStatus"/> values are not the same. </summary>
        public static bool operator !=(DataAvailabilityStatus left, DataAvailabilityStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataAvailabilityStatus"/>. </summary>
        public static implicit operator DataAvailabilityStatus(string value) => new DataAvailabilityStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataAvailabilityStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataAvailabilityStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
