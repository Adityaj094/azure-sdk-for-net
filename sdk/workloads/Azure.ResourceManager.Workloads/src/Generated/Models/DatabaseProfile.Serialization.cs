// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class DatabaseProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatabaseType.ToString());
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            writer.WritePropertyName("sku"u8);
            writer.WriteStringValue(Sku);
            writer.WritePropertyName("tier"u8);
            writer.WriteStringValue(Tier.ToSerialString());
            if (Optional.IsDefined(HAEnabled))
            {
                writer.WritePropertyName("haEnabled"u8);
                writer.WriteStringValue(HAEnabled.Value.ToString());
            }
            if (Optional.IsDefined(StorageSku))
            {
                writer.WritePropertyName("storageSku"u8);
                writer.WriteStringValue(StorageSku);
            }
            if (Optional.IsDefined(StorageInGB))
            {
                writer.WritePropertyName("storageInGB"u8);
                writer.WriteNumberValue(StorageInGB.Value);
            }
            if (Optional.IsDefined(StorageIops))
            {
                writer.WritePropertyName("storageIops"u8);
                writer.WriteNumberValue(StorageIops.Value);
            }
            if (Optional.IsDefined(BackupRetentionDays))
            {
                writer.WritePropertyName("backupRetentionDays"u8);
                writer.WriteNumberValue(BackupRetentionDays.Value);
            }
            if (Optional.IsDefined(SslEnforcementEnabled))
            {
                writer.WritePropertyName("sslEnforcementEnabled"u8);
                writer.WriteStringValue(SslEnforcementEnabled.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DatabaseProfile DeserializeDatabaseProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DatabaseType type = default;
            Optional<string> serverName = default;
            Optional<string> version = default;
            string sku = default;
            DatabaseTier tier = default;
            Optional<HAEnabled> haEnabled = default;
            Optional<string> storageSku = default;
            Optional<long> storageInGB = default;
            Optional<long> storageIops = default;
            Optional<int> backupRetentionDays = default;
            Optional<EnableSslEnforcement> sslEnforcementEnabled = default;
            Optional<ResourceIdentifier> serverResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new DatabaseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString().ToDatabaseTier();
                    continue;
                }
                if (property.NameEquals("haEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    haEnabled = new HAEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageSku"u8))
                {
                    storageSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageInGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageInGB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("storageIops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageIops = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("backupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sslEnforcementEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sslEnforcementEnabled = new EnableSslEnforcement(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serverResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serverResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new DatabaseProfile(type, serverName.Value, version.Value, sku, tier, Optional.ToNullable(haEnabled), storageSku.Value, Optional.ToNullable(storageInGB), Optional.ToNullable(storageIops), Optional.ToNullable(backupRetentionDays), Optional.ToNullable(sslEnforcementEnabled), serverResourceId.Value);
        }
    }
}
