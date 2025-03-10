// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerServerVersionCapability
    {
        internal static PostgreSqlFlexibleServerServerVersionCapability DeserializePostgreSqlFlexibleServerServerVersionCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<string>> supportedVersionsToUpgrade = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerVCoreCapability>> supportedVcores = default;
            Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedVersionsToUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedVersionsToUpgrade = array;
                    continue;
                }
                if (property.NameEquals("supportedVcores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PostgreSqlFlexibleServerVCoreCapability> array = new List<PostgreSqlFlexibleServerVCoreCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerVCoreCapability.DeserializePostgreSqlFlexibleServerVCoreCapability(item));
                    }
                    supportedVcores = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerServerVersionCapability(name.Value, Optional.ToList(supportedVersionsToUpgrade), Optional.ToList(supportedVcores), status.Value);
        }
    }
}
