// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Affinity Strength. </summary>
    public readonly partial struct VmHostPlacementPolicyAffinityStrength : IEquatable<VmHostPlacementPolicyAffinityStrength>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VmHostPlacementPolicyAffinityStrength"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VmHostPlacementPolicyAffinityStrength(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ShouldValue = "Should";
        private const string MustValue = "Must";

        /// <summary> is should. </summary>
        public static VmHostPlacementPolicyAffinityStrength Should { get; } = new VmHostPlacementPolicyAffinityStrength(ShouldValue);
        /// <summary> is must. </summary>
        public static VmHostPlacementPolicyAffinityStrength Must { get; } = new VmHostPlacementPolicyAffinityStrength(MustValue);
        /// <summary> Determines if two <see cref="VmHostPlacementPolicyAffinityStrength"/> values are the same. </summary>
        public static bool operator ==(VmHostPlacementPolicyAffinityStrength left, VmHostPlacementPolicyAffinityStrength right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VmHostPlacementPolicyAffinityStrength"/> values are not the same. </summary>
        public static bool operator !=(VmHostPlacementPolicyAffinityStrength left, VmHostPlacementPolicyAffinityStrength right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VmHostPlacementPolicyAffinityStrength"/>. </summary>
        public static implicit operator VmHostPlacementPolicyAffinityStrength(string value) => new VmHostPlacementPolicyAffinityStrength(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VmHostPlacementPolicyAffinityStrength other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VmHostPlacementPolicyAffinityStrength other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
