// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    internal partial class CustomRuleList : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules");
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static CustomRuleList DeserializeCustomRuleList(JsonElement element)
        {
            Optional<IList<WebApplicationCustomRule>> rules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WebApplicationCustomRule> array = new List<WebApplicationCustomRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebApplicationCustomRule.DeserializeWebApplicationCustomRule(item));
                    }
                    rules = array;
                    continue;
                }
            }
            return new CustomRuleList(Optional.ToList(rules));
        }
    }
}
