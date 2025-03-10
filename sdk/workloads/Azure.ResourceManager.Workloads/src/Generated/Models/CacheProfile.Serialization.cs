// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class CacheProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("skuName"u8);
            writer.WriteStringValue(SkuName);
            writer.WritePropertyName("family"u8);
            writer.WriteStringValue(Family.ToString());
            writer.WritePropertyName("capacity"u8);
            writer.WriteNumberValue(Capacity);
            writer.WriteEndObject();
        }

        internal static CacheProfile DeserializeCacheProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            string skuName = default;
            RedisCacheFamily family = default;
            long capacity = default;
            Optional<ResourceIdentifier> cacheResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuName"u8))
                {
                    skuName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("family"u8))
                {
                    family = new RedisCacheFamily(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    capacity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cacheResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cacheResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new CacheProfile(name.Value, skuName, family, capacity, cacheResourceId.Value);
        }
    }
}
