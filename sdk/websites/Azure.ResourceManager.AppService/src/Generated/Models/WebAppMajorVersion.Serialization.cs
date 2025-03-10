// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppMajorVersion
    {
        internal static WebAppMajorVersion DeserializeWebAppMajorVersion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayText = default;
            Optional<string> value = default;
            Optional<IReadOnlyList<WebAppMinorVersion>> minorVersions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayText"u8))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minorVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WebAppMinorVersion> array = new List<WebAppMinorVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebAppMinorVersion.DeserializeWebAppMinorVersion(item));
                    }
                    minorVersions = array;
                    continue;
                }
            }
            return new WebAppMajorVersion(displayText.Value, value.Value, Optional.ToList(minorVersions));
        }
    }
}
