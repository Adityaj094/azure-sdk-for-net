// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class Control
    {
        internal static Control DeserializeControl(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> controlId = default;
            Optional<string> controlShortName = default;
            Optional<string> controlFullName = default;
            Optional<ControlType> controlType = default;
            Optional<string> controlDescription = default;
            Optional<string> controlDescriptionHyperLink = default;
            Optional<ControlStatus> controlStatus = default;
            Optional<IReadOnlyList<Assessment>> assessments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("controlId"u8))
                {
                    controlId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlShortName"u8))
                {
                    controlShortName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlFullName"u8))
                {
                    controlFullName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    controlType = new ControlType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controlDescription"u8))
                {
                    controlDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlDescriptionHyperLink"u8))
                {
                    controlDescriptionHyperLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    controlStatus = new ControlStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assessments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Assessment> array = new List<Assessment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Assessment.DeserializeAssessment(item));
                    }
                    assessments = array;
                    continue;
                }
            }
            return new Control(controlId.Value, controlShortName.Value, controlFullName.Value, Optional.ToNullable(controlType), controlDescription.Value, controlDescriptionHyperLink.Value, Optional.ToNullable(controlStatus), Optional.ToList(assessments));
        }
    }
}
