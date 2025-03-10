// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementPolicyApprovalRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("setting"u8);
                writer.WriteObjectValue(Settings);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteObjectValue(Target);
            }
            writer.WriteEndObject();
        }

        internal static RoleManagementPolicyApprovalRule DeserializeRoleManagementPolicyApprovalRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RoleManagementApprovalSettings> setting = default;
            Optional<string> id = default;
            RoleManagementPolicyRuleType ruleType = default;
            Optional<RoleManagementPolicyRuleTarget> target = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("setting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    setting = RoleManagementApprovalSettings.DeserializeRoleManagementApprovalSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = new RoleManagementPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    target = RoleManagementPolicyRuleTarget.DeserializeRoleManagementPolicyRuleTarget(property.Value);
                    continue;
                }
            }
            return new RoleManagementPolicyApprovalRule(id.Value, ruleType, target.Value, setting.Value);
        }
    }
}
