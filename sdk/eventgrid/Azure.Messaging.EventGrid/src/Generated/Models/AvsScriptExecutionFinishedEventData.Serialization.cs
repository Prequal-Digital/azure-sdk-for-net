// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AvsScriptExecutionFinishedEventDataConverter))]
    public partial class AvsScriptExecutionFinishedEventData
    {
        internal static AvsScriptExecutionFinishedEventData DeserializeAvsScriptExecutionFinishedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, string> namedOutputs = default;
            string operationId = default;
            string cmdletId = default;
            IReadOnlyList<string> output = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("namedOutputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    namedOutputs = dictionary;
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cmdletId"u8))
                {
                    cmdletId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    output = array;
                    continue;
                }
            }
            return new AvsScriptExecutionFinishedEventData(operationId, cmdletId, output ?? new ChangeTrackingList<string>(), namedOutputs ?? new ChangeTrackingDictionary<string, string>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AvsScriptExecutionFinishedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAvsScriptExecutionFinishedEventData(document.RootElement);
        }

        internal partial class AvsScriptExecutionFinishedEventDataConverter : JsonConverter<AvsScriptExecutionFinishedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AvsScriptExecutionFinishedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AvsScriptExecutionFinishedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAvsScriptExecutionFinishedEventData(document.RootElement);
            }
        }
    }
}
