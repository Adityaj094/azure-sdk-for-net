// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    [JsonConverter(typeof(OciManifestConverter))]
    public partial class OciManifest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Config))
            {
                writer.WritePropertyName("config"u8);
                writer.WriteObjectValue(Config);
            }
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers"u8);
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Annotations))
            {
                if (Annotations != null)
                {
                    writer.WritePropertyName("annotations"u8);
                    writer.WriteObjectValue(Annotations);
                }
                else
                {
                    writer.WriteNull("annotations");
                }
            }
            if (Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion"u8);
                writer.WriteNumberValue(SchemaVersion.Value);
            }
            writer.WriteEndObject();
        }

        internal static OciManifest DeserializeOciManifest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OciBlobDescriptor> config = default;
            Optional<IList<OciBlobDescriptor>> layers = default;
            Optional<OciAnnotations> annotations = default;
            Optional<int> schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("config"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    config = OciBlobDescriptor.DeserializeOciBlobDescriptor(property.Value);
                    continue;
                }
                if (property.NameEquals("layers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<OciBlobDescriptor> array = new List<OciBlobDescriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OciBlobDescriptor.DeserializeOciBlobDescriptor(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        annotations = null;
                        continue;
                    }
                    annotations = OciAnnotations.DeserializeOciAnnotations(property.Value);
                    continue;
                }
                if (property.NameEquals("schemaVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new OciManifest(config.Value, Optional.ToList(layers), annotations.Value, Optional.ToNullable(schemaVersion));
        }

        internal partial class OciManifestConverter : JsonConverter<OciManifest>
        {
            public override void Write(Utf8JsonWriter writer, OciManifest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override OciManifest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeOciManifest(document.RootElement);
            }
        }
    }
}
