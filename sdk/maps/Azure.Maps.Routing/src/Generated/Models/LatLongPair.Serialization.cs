// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    internal partial class LatLongPair
    {
        internal static LatLongPair DeserializeLatLongPair(JsonElement element)
        {
            Optional<double> latitude = default;
            Optional<double> longitude = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("latitude"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    latitude = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("longitude"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    longitude = property.Value.GetDouble();
                    continue;
                }
            }
            return new LatLongPair(Optional.ToNullable(latitude), Optional.ToNullable(longitude));
        }
    }
}
