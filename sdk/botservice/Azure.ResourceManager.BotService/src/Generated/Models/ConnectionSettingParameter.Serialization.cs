// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class ConnectionSettingParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
            }
            if (Optional.IsDefined(Value))
            {
                if (Value != null)
                {
                    writer.WritePropertyName("value"u8);
                    writer.WriteStringValue(Value);
                }
                else
                {
                    writer.WriteNull("value");
                }
            }
            writer.WriteEndObject();
        }

        internal static ConnectionSettingParameter DeserializeConnectionSettingParameter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> key = default;
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        value = null;
                        continue;
                    }
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new ConnectionSettingParameter(key.Value, value.Value);
        }
    }
}
