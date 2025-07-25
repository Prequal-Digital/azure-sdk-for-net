// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// The environment variable to pass to the script in the container instance.
/// </summary>
public partial class ScriptEnvironmentVariable : ProvisionableConstruct
{
    /// <summary>
    /// The name of the environment variable.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The value of the environment variable.
    /// </summary>
    public BicepValue<string> Value 
    {
        get { Initialize(); return _value!; }
        set { Initialize(); _value!.Assign(value); }
    }
    private BicepValue<string>? _value;

    /// <summary>
    /// The value of the secure environment variable.
    /// </summary>
    public BicepValue<string> SecureValue 
    {
        get { Initialize(); return _secureValue!; }
        set { Initialize(); _secureValue!.Assign(value); }
    }
    private BicepValue<string>? _secureValue;

    /// <summary>
    /// Creates a new ScriptEnvironmentVariable.
    /// </summary>
    public ScriptEnvironmentVariable()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ScriptEnvironmentVariable.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _value = DefineProperty<string>("Value", ["value"]);
        _secureValue = DefineProperty<string>("SecureValue", ["secureValue"]);
    }
}
