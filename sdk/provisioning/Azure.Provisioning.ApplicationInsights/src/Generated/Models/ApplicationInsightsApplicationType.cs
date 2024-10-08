// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.ApplicationInsights;

/// <summary>
/// Type of application being monitored.
/// </summary>
public enum ApplicationInsightsApplicationType
{
    /// <summary>
    /// web.
    /// </summary>
    [DataMember(Name = "web")]
    Web,

    /// <summary>
    /// other.
    /// </summary>
    [DataMember(Name = "other")]
    Other,
}
