// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Type of service associated with the phone number. </summary>
    public readonly partial struct OperatorNumberType : IEquatable<OperatorNumberType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperatorNumberType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperatorNumberType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "unknown";
        private const string OtherValue = "other";
        private const string GeographicValue = "geographic";
        private const string MobileValue = "mobile";

        /// <summary> unknown. </summary>
        public static OperatorNumberType Unknown { get; } = new OperatorNumberType(UnknownValue);
        /// <summary> other. </summary>
        public static OperatorNumberType Other { get; } = new OperatorNumberType(OtherValue);
        /// <summary> geographic. </summary>
        public static OperatorNumberType Geographic { get; } = new OperatorNumberType(GeographicValue);
        /// <summary> mobile. </summary>
        public static OperatorNumberType Mobile { get; } = new OperatorNumberType(MobileValue);
        /// <summary> Determines if two <see cref="OperatorNumberType"/> values are the same. </summary>
        public static bool operator ==(OperatorNumberType left, OperatorNumberType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperatorNumberType"/> values are not the same. </summary>
        public static bool operator !=(OperatorNumberType left, OperatorNumberType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OperatorNumberType"/>. </summary>
        public static implicit operator OperatorNumberType(string value) => new OperatorNumberType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperatorNumberType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperatorNumberType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
