// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmentSubnetNetworkHealth
    {
        internal static IntegrationServiceEnvironmentSubnetNetworkHealth DeserializeIntegrationServiceEnvironmentSubnetNetworkHealth(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<IntegrationServiceEnvironmentNetworkDependency>> outboundNetworkDependencies = default;
            Optional<IntegrationServiceEnvironmentNetworkDependencyHealth> outboundNetworkHealth = default;
            IntegrationServiceEnvironmentNetworkEndPointAccessibilityState networkDependencyHealthState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outboundNetworkDependencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IntegrationServiceEnvironmentNetworkDependency> array = new List<IntegrationServiceEnvironmentNetworkDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationServiceEnvironmentNetworkDependency.DeserializeIntegrationServiceEnvironmentNetworkDependency(item));
                    }
                    outboundNetworkDependencies = array;
                    continue;
                }
                if (property.NameEquals("outboundNetworkHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    outboundNetworkHealth = IntegrationServiceEnvironmentNetworkDependencyHealth.DeserializeIntegrationServiceEnvironmentNetworkDependencyHealth(property.Value);
                    continue;
                }
                if (property.NameEquals("networkDependencyHealthState"u8))
                {
                    networkDependencyHealthState = new IntegrationServiceEnvironmentNetworkEndPointAccessibilityState(property.Value.GetString());
                    continue;
                }
            }
            return new IntegrationServiceEnvironmentSubnetNetworkHealth(Optional.ToList(outboundNetworkDependencies), outboundNetworkHealth.Value, networkDependencyHealthState);
        }
    }
}
