// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class UserDefinedResourcesProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Query != null)
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            else
            {
                writer.WriteNull("query");
            }
            if (QuerySubscriptions != null)
            {
                writer.WritePropertyName("querySubscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in QuerySubscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("querySubscriptions");
            }
            writer.WriteEndObject();
        }

        internal static UserDefinedResourcesProperties DeserializeUserDefinedResourcesProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string query = default;
            IList<string> querySubscriptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        query = null;
                        continue;
                    }
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("querySubscriptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        querySubscriptions = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    querySubscriptions = array;
                    continue;
                }
            }
            return new UserDefinedResourcesProperties(query, querySubscriptions);
        }
    }
}
