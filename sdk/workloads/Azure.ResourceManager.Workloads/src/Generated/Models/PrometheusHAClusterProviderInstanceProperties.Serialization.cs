// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class PrometheusHAClusterProviderInstanceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrometheusUri))
            {
                writer.WritePropertyName("prometheusUrl"u8);
                writer.WriteStringValue(PrometheusUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (Optional.IsDefined(Sid))
            {
                writer.WritePropertyName("sid"u8);
                writer.WriteStringValue(Sid);
            }
            if (Optional.IsDefined(ClusterName))
            {
                writer.WritePropertyName("clusterName"u8);
                writer.WriteStringValue(ClusterName);
            }
            writer.WritePropertyName("providerType"u8);
            writer.WriteStringValue(ProviderType);
            writer.WriteEndObject();
        }

        internal static PrometheusHAClusterProviderInstanceProperties DeserializePrometheusHAClusterProviderInstanceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> prometheusUrl = default;
            Optional<string> hostname = default;
            Optional<string> sid = default;
            Optional<string> clusterName = default;
            string providerType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prometheusUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        prometheusUrl = null;
                        continue;
                    }
                    prometheusUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sid"u8))
                {
                    sid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterName"u8))
                {
                    clusterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
            }
            return new PrometheusHAClusterProviderInstanceProperties(providerType, prometheusUrl.Value, hostname.Value, sid.Value, clusterName.Value);
        }
    }
}
