// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAutomationSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EventSource))
            {
                writer.WritePropertyName("eventSource");
                writer.WriteStringValue(EventSource.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RuleSets))
            {
                writer.WritePropertyName("ruleSets");
                writer.WriteStartArray();
                foreach (var item in RuleSets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SecurityAutomationSource DeserializeSecurityAutomationSource(JsonElement element)
        {
            Optional<SecurityEventSource> eventSource = default;
            Optional<IList<SecurityAutomationRuleSet>> ruleSets = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventSource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eventSource = new SecurityEventSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ruleSets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SecurityAutomationRuleSet> array = new List<SecurityAutomationRuleSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityAutomationRuleSet.DeserializeSecurityAutomationRuleSet(item));
                    }
                    ruleSets = array;
                    continue;
                }
            }
            return new SecurityAutomationSource(Optional.ToNullable(eventSource), Optional.ToList(ruleSets));
        }
    }
}
