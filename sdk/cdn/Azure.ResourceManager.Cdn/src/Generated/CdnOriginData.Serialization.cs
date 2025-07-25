// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class CdnOriginData : IUtf8JsonSerializable, IJsonModel<CdnOriginData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CdnOriginData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CdnOriginData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnOriginData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(HttpPort))
            {
                if (HttpPort != null)
                {
                    writer.WritePropertyName("httpPort"u8);
                    writer.WriteNumberValue(HttpPort.Value);
                }
                else
                {
                    writer.WriteNull("httpPort");
                }
            }
            if (Optional.IsDefined(HttpsPort))
            {
                if (HttpsPort != null)
                {
                    writer.WritePropertyName("httpsPort"u8);
                    writer.WriteNumberValue(HttpsPort.Value);
                }
                else
                {
                    writer.WriteNull("httpsPort");
                }
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader"u8);
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(Priority))
            {
                if (Priority != null)
                {
                    writer.WritePropertyName("priority"u8);
                    writer.WriteNumberValue(Priority.Value);
                }
                else
                {
                    writer.WriteNull("priority");
                }
            }
            if (Optional.IsDefined(Weight))
            {
                if (Weight != null)
                {
                    writer.WritePropertyName("weight"u8);
                    writer.WriteNumberValue(Weight.Value);
                }
                else
                {
                    writer.WriteNull("weight");
                }
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(PrivateLinkAlias))
            {
                writer.WritePropertyName("privateLinkAlias"u8);
                writer.WriteStringValue(PrivateLinkAlias);
            }
            if (Optional.IsDefined(PrivateLinkResourceId))
            {
                if (PrivateLinkResourceId != null)
                {
                    writer.WritePropertyName("privateLinkResourceId"u8);
                    writer.WriteStringValue(PrivateLinkResourceId);
                }
                else
                {
                    writer.WriteNull("privateLinkResourceId");
                }
            }
            if (Optional.IsDefined(PrivateLinkLocation))
            {
                writer.WritePropertyName("privateLinkLocation"u8);
                writer.WriteStringValue(PrivateLinkLocation);
            }
            if (Optional.IsDefined(PrivateLinkApprovalMessage))
            {
                writer.WritePropertyName("privateLinkApprovalMessage"u8);
                writer.WriteStringValue(PrivateLinkApprovalMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateEndpointStatus))
            {
                if (PrivateEndpointStatus != null)
                {
                    writer.WritePropertyName("privateEndpointStatus"u8);
                    writer.WriteStringValue(PrivateEndpointStatus.Value.ToString());
                }
                else
                {
                    writer.WriteNull("privateEndpointStatus");
                }
            }
            writer.WriteEndObject();
        }

        CdnOriginData IJsonModel<CdnOriginData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnOriginData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnOriginData(document.RootElement, options);
        }

        internal static CdnOriginData DeserializeCdnOriginData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string hostName = default;
            int? httpPort = default;
            int? httpsPort = default;
            string originHostHeader = default;
            int? priority = default;
            int? weight = default;
            bool? enabled = default;
            string privateLinkAlias = default;
            ResourceIdentifier privateLinkResourceId = default;
            string privateLinkLocation = default;
            string privateLinkApprovalMessage = default;
            OriginResourceState? resourceState = default;
            OriginProvisioningState? provisioningState = default;
            PrivateEndpointStatus? privateEndpointStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerCdnContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("httpPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                httpPort = null;
                                continue;
                            }
                            httpPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("httpsPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                httpsPort = null;
                                continue;
                            }
                            httpsPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("originHostHeader"u8))
                        {
                            originHostHeader = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                priority = null;
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("weight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                weight = null;
                                continue;
                            }
                            weight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkAlias"u8))
                        {
                            privateLinkAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                privateLinkResourceId = null;
                                continue;
                            }
                            privateLinkResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkLocation"u8))
                        {
                            privateLinkLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkApprovalMessage"u8))
                        {
                            privateLinkApprovalMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new OriginResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new OriginProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                privateEndpointStatus = null;
                                continue;
                            }
                            privateEndpointStatus = new PrivateEndpointStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CdnOriginData(
                id,
                name,
                type,
                systemData,
                hostName,
                httpPort,
                httpsPort,
                originHostHeader,
                priority,
                weight,
                enabled,
                privateLinkAlias,
                privateLinkResourceId,
                privateLinkLocation,
                privateLinkApprovalMessage,
                resourceState,
                provisioningState,
                privateEndpointStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CdnOriginData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCdnContext.Default);
                default:
                    throw new FormatException($"The model {nameof(CdnOriginData)} does not support writing '{options.Format}' format.");
            }
        }

        CdnOriginData IPersistableModel<CdnOriginData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCdnOriginData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CdnOriginData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CdnOriginData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
