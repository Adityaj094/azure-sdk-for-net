// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GovernanceAssignmentAdditionalInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TicketNumber))
            {
                writer.WritePropertyName("ticketNumber"u8);
                writer.WriteNumberValue(TicketNumber.Value);
            }
            if (Optional.IsDefined(TicketLink))
            {
                writer.WritePropertyName("ticketLink"u8);
                writer.WriteStringValue(TicketLink);
            }
            if (Optional.IsDefined(TicketStatus))
            {
                writer.WritePropertyName("ticketStatus"u8);
                writer.WriteStringValue(TicketStatus);
            }
            writer.WriteEndObject();
        }

        internal static GovernanceAssignmentAdditionalInfo DeserializeGovernanceAssignmentAdditionalInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> ticketNumber = default;
            Optional<string> ticketLink = default;
            Optional<string> ticketStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ticketNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ticketNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ticketLink"u8))
                {
                    ticketLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ticketStatus"u8))
                {
                    ticketStatus = property.Value.GetString();
                    continue;
                }
            }
            return new GovernanceAssignmentAdditionalInfo(Optional.ToNullable(ticketNumber), ticketLink.Value, ticketStatus.Value);
        }
    }
}
