// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AzureFirewallApplicationRuleProtocol : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProtocolType))
            {
                writer.WritePropertyName("protocolType"u8);
                writer.WriteStringValue(ProtocolType.Value.ToString());
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureFirewallApplicationRuleProtocol DeserializeAzureFirewallApplicationRuleProtocol(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureFirewallApplicationRuleProtocolType> protocolType = default;
            Optional<int> port = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protocolType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protocolType = new AzureFirewallApplicationRuleProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
            }
            return new AzureFirewallApplicationRuleProtocol(Optional.ToNullable(protocolType), Optional.ToNullable(port));
        }
    }
}
