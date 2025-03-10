// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class DeepCreatedOriginGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(HealthProbeSettings))
            {
                if (HealthProbeSettings != null)
                {
                    writer.WritePropertyName("healthProbeSettings"u8);
                    writer.WriteObjectValue(HealthProbeSettings);
                }
                else
                {
                    writer.WriteNull("healthProbeSettings");
                }
            }
            if (Optional.IsCollectionDefined(Origins))
            {
                writer.WritePropertyName("origins"u8);
                writer.WriteStartArray();
                foreach (var item in Origins)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrafficRestorationTimeToHealedOrNewEndpointsInMinutes))
            {
                if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes != null)
                {
                    writer.WritePropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"u8);
                    writer.WriteNumberValue(TrafficRestorationTimeToHealedOrNewEndpointsInMinutes.Value);
                }
                else
                {
                    writer.WriteNull("trafficRestorationTimeToHealedOrNewEndpointsInMinutes");
                }
            }
            if (Optional.IsDefined(ResponseBasedOriginErrorDetectionSettings))
            {
                if (ResponseBasedOriginErrorDetectionSettings != null)
                {
                    writer.WritePropertyName("responseBasedOriginErrorDetectionSettings"u8);
                    writer.WriteObjectValue(ResponseBasedOriginErrorDetectionSettings);
                }
                else
                {
                    writer.WriteNull("responseBasedOriginErrorDetectionSettings");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DeepCreatedOriginGroup DeserializeDeepCreatedOriginGroup(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<HealthProbeSettings> healthProbeSettings = default;
            Optional<IList<WritableSubResource>> origins = default;
            Optional<int?> trafficRestorationTimeToHealedOrNewEndpointsInMinutes = default;
            Optional<ResponseBasedOriginErrorDetectionSettings> responseBasedOriginErrorDetectionSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("healthProbeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                healthProbeSettings = null;
                                continue;
                            }
                            healthProbeSettings = HealthProbeSettings.DeserializeHealthProbeSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("origins"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            origins = array;
                            continue;
                        }
                        if (property0.NameEquals("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                trafficRestorationTimeToHealedOrNewEndpointsInMinutes = null;
                                continue;
                            }
                            trafficRestorationTimeToHealedOrNewEndpointsInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("responseBasedOriginErrorDetectionSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                responseBasedOriginErrorDetectionSettings = null;
                                continue;
                            }
                            responseBasedOriginErrorDetectionSettings = ResponseBasedOriginErrorDetectionSettings.DeserializeResponseBasedOriginErrorDetectionSettings(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DeepCreatedOriginGroup(name, healthProbeSettings.Value, Optional.ToList(origins), Optional.ToNullable(trafficRestorationTimeToHealedOrNewEndpointsInMinutes), responseBasedOriginErrorDetectionSettings.Value);
        }
    }
}
