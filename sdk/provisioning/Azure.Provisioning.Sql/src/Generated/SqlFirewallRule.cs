// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlFirewallRule.
/// </summary>
public partial class SqlFirewallRule : ProvisionableResource
{
    /// <summary>
    /// The name of the firewall rule.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The end IP address of the firewall rule. Must be IPv4 format. Must be
    /// greater than or equal to startIpAddress. Use value &apos;0.0.0.0&apos;
    /// for all Azure-internal IP addresses.
    /// </summary>
    public BicepValue<string> EndIPAddress 
    {
        get { Initialize(); return _endIPAddress!; }
        set { Initialize(); _endIPAddress!.Assign(value); }
    }
    private BicepValue<string>? _endIPAddress;

    /// <summary>
    /// The start IP address of the firewall rule. Must be IPv4 format. Use
    /// value &apos;0.0.0.0&apos; for all Azure-internal IP addresses.
    /// </summary>
    public BicepValue<string> StartIPAddress 
    {
        get { Initialize(); return _startIPAddress!; }
        set { Initialize(); _startIPAddress!.Assign(value); }
    }
    private BicepValue<string>? _startIPAddress;

    /// <summary>
    /// Resource ID.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets or sets a reference to the parent SqlServer.
    /// </summary>
    public SqlServer? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<SqlServer>? _parent;

    /// <summary>
    /// Creates a new SqlFirewallRule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlFirewallRule resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlFirewallRule.</param>
    public SqlFirewallRule(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/firewallRules", resourceVersion ?? "2021-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SqlFirewallRule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _endIPAddress = DefineProperty<string>("EndIPAddress", ["properties", "endIpAddress"]);
        _startIPAddress = DefineProperty<string>("StartIPAddress", ["properties", "startIpAddress"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _parent = DefineResource<SqlServer>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlFirewallRule resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";

        /// <summary>
        /// 2014-01-01.
        /// </summary>
        public static readonly string V2014_01_01 = "2014-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlFirewallRule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlFirewallRule resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlFirewallRule.</param>
    /// <returns>The existing SqlFirewallRule resource.</returns>
    public static SqlFirewallRule FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this SqlFirewallRule resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 128, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period | ResourceNameCharacters.Parentheses);
}
