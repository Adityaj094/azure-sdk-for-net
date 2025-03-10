// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class KustoClusterDataSetMapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("dataSetId"u8);
            writer.WriteStringValue(DataSetId);
            writer.WritePropertyName("kustoClusterResourceId"u8);
            writer.WriteStringValue(KustoClusterResourceId);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static KustoClusterDataSetMapping DeserializeKustoClusterDataSetMapping(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataSetMappingKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Guid dataSetId = default;
            Optional<DataSetMappingStatus> dataSetMappingStatus = default;
            ResourceIdentifier kustoClusterResourceId = default;
            Optional<AzureLocation> location = default;
            Optional<DataShareProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DataSetMappingKind(property.Value.GetString());
                    continue;
                }
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
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("dataSetId"u8))
                        {
                            dataSetId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("dataSetMappingStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataSetMappingStatus = new DataSetMappingStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("kustoClusterResourceId"u8))
                        {
                            kustoClusterResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("location"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            location = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new DataShareProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new KustoClusterDataSetMapping(id, name, type, systemData.Value, kind, dataSetId, Optional.ToNullable(dataSetMappingStatus), kustoClusterResourceId, Optional.ToNullable(location), Optional.ToNullable(provisioningState));
        }
    }
}
