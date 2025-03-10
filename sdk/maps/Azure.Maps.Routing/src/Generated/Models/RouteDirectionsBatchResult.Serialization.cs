// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteDirectionsBatchResult
    {
        internal static RouteDirectionsBatchResult DeserializeRouteDirectionsBatchResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RouteDirectionsBatchItem>> batchItems = default;
            Optional<BatchResultSummary> summary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("batchItems"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RouteDirectionsBatchItem> array = new List<RouteDirectionsBatchItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteDirectionsBatchItem.DeserializeRouteDirectionsBatchItem(item));
                    }
                    batchItems = array;
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    summary = BatchResultSummary.DeserializeBatchResultSummary(property.Value);
                    continue;
                }
            }
            return new RouteDirectionsBatchResult(summary.Value, Optional.ToList(batchItems));
        }
    }
}
