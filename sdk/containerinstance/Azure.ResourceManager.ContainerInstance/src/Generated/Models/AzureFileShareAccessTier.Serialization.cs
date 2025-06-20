// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    internal static partial class AzureFileShareAccessTierExtensions
    {
        public static string ToSerialString(this AzureFileShareAccessTier value) => value switch
        {
            AzureFileShareAccessTier.Cool => "Cool",
            AzureFileShareAccessTier.Hot => "Hot",
            AzureFileShareAccessTier.Premium => "Premium",
            AzureFileShareAccessTier.TransactionOptimized => "TransactionOptimized",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AzureFileShareAccessTier value.")
        };

        public static AzureFileShareAccessTier ToAzureFileShareAccessTier(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Cool")) return AzureFileShareAccessTier.Cool;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Hot")) return AzureFileShareAccessTier.Hot;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Premium")) return AzureFileShareAccessTier.Premium;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "TransactionOptimized")) return AzureFileShareAccessTier.TransactionOptimized;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AzureFileShareAccessTier value.");
        }
    }
}
