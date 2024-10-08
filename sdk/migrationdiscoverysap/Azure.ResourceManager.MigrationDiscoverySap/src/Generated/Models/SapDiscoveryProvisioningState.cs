// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MigrationDiscoverySap.Models
{
    /// <summary> Defines the provisioning states. </summary>
    public readonly partial struct SapDiscoveryProvisioningState : IEquatable<SapDiscoveryProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SapDiscoveryProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SapDiscoveryProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string UpdatingValue = "Updating";
        private const string FailedValue = "Failed";
        private const string CreatingValue = "Creating";
        private const string CanceledValue = "Canceled";
        private const string AcceptedValue = "Accepted";
        private const string DeletingValue = "Deleting";
        private const string UnknownValue = "Unknown";

        /// <summary> The provisioning state Succeeded. </summary>
        public static SapDiscoveryProvisioningState Succeeded { get; } = new SapDiscoveryProvisioningState(SucceededValue);
        /// <summary> The provisioning state Updating. </summary>
        public static SapDiscoveryProvisioningState Updating { get; } = new SapDiscoveryProvisioningState(UpdatingValue);
        /// <summary> The provisioning state Failed. </summary>
        public static SapDiscoveryProvisioningState Failed { get; } = new SapDiscoveryProvisioningState(FailedValue);
        /// <summary> The provisioning state Creating. </summary>
        public static SapDiscoveryProvisioningState Creating { get; } = new SapDiscoveryProvisioningState(CreatingValue);
        /// <summary> The provisioning state Cancelled. </summary>
        public static SapDiscoveryProvisioningState Canceled { get; } = new SapDiscoveryProvisioningState(CanceledValue);
        /// <summary> The provisioning state Accepted. </summary>
        public static SapDiscoveryProvisioningState Accepted { get; } = new SapDiscoveryProvisioningState(AcceptedValue);
        /// <summary> The provisioning state Deleting. </summary>
        public static SapDiscoveryProvisioningState Deleting { get; } = new SapDiscoveryProvisioningState(DeletingValue);
        /// <summary> The provisioning state Unknown. </summary>
        public static SapDiscoveryProvisioningState Unknown { get; } = new SapDiscoveryProvisioningState(UnknownValue);
        /// <summary> Determines if two <see cref="SapDiscoveryProvisioningState"/> values are the same. </summary>
        public static bool operator ==(SapDiscoveryProvisioningState left, SapDiscoveryProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SapDiscoveryProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(SapDiscoveryProvisioningState left, SapDiscoveryProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SapDiscoveryProvisioningState"/>. </summary>
        public static implicit operator SapDiscoveryProvisioningState(string value) => new SapDiscoveryProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SapDiscoveryProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SapDiscoveryProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
