// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class ThreeTierConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration);
            }
            writer.WritePropertyName("centralServer"u8);
            writer.WriteObjectValue(CentralServer);
            writer.WritePropertyName("applicationServer"u8);
            writer.WriteObjectValue(ApplicationServer);
            writer.WritePropertyName("databaseServer"u8);
            writer.WriteObjectValue(DatabaseServer);
            if (Optional.IsDefined(HighAvailabilityConfig))
            {
                writer.WritePropertyName("highAvailabilityConfig"u8);
                writer.WriteObjectValue(HighAvailabilityConfig);
            }
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteStringValue(DeploymentType.ToString());
            writer.WritePropertyName("appResourceGroup"u8);
            writer.WriteStringValue(AppResourceGroup);
            writer.WriteEndObject();
        }

        internal static ThreeTierConfiguration DeserializeThreeTierConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetworkConfiguration> networkConfiguration = default;
            CentralServerConfiguration centralServer = default;
            ApplicationServerConfiguration applicationServer = default;
            DatabaseConfiguration databaseServer = default;
            Optional<HighAvailabilityConfiguration> highAvailabilityConfig = default;
            SapDeploymentType deploymentType = default;
            string appResourceGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkConfiguration = NetworkConfiguration.DeserializeNetworkConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("centralServer"u8))
                {
                    centralServer = CentralServerConfiguration.DeserializeCentralServerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("applicationServer"u8))
                {
                    applicationServer = ApplicationServerConfiguration.DeserializeApplicationServerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("databaseServer"u8))
                {
                    databaseServer = DatabaseConfiguration.DeserializeDatabaseConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("highAvailabilityConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    highAvailabilityConfig = HighAvailabilityConfiguration.DeserializeHighAvailabilityConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("deploymentType"u8))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appResourceGroup"u8))
                {
                    appResourceGroup = property.Value.GetString();
                    continue;
                }
            }
            return new ThreeTierConfiguration(deploymentType, appResourceGroup, networkConfiguration.Value, centralServer, applicationServer, databaseServer, highAvailabilityConfig.Value);
        }
    }
}
