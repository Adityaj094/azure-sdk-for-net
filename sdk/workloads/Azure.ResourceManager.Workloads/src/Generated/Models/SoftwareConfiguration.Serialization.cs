// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SoftwareConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("softwareInstallationType"u8);
            writer.WriteStringValue(SoftwareInstallationType.ToString());
            writer.WriteEndObject();
        }

        internal static SoftwareConfiguration DeserializeSoftwareConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("softwareInstallationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SAPInstallWithoutOSConfig": return SapInstallWithoutOSConfigSoftwareConfiguration.DeserializeSapInstallWithoutOSConfigSoftwareConfiguration(element);
                    case "ServiceInitiated": return ServiceInitiatedSoftwareConfiguration.DeserializeServiceInitiatedSoftwareConfiguration(element);
                }
            }
            return UnknownSoftwareConfiguration.DeserializeUnknownSoftwareConfiguration(element);
        }
    }
}
