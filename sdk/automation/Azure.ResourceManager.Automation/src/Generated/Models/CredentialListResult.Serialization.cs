// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class CredentialListResult
    {
        internal static CredentialListResult DeserializeCredentialListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CredentialData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CredentialData> array = new List<CredentialData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CredentialData.DeserializeCredentialData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new CredentialListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
