// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class UnknownSecuritySubAssessmentAdditionalInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("assessedResourceType");
            writer.WriteStringValue(AssessedResourceType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownSecuritySubAssessmentAdditionalInfo DeserializeUnknownSecuritySubAssessmentAdditionalInfo(JsonElement element)
        {
            AssessedResourceType assessedResourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assessedResourceType"))
                {
                    assessedResourceType = new AssessedResourceType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownSecuritySubAssessmentAdditionalInfo(assessedResourceType);
        }
    }
}
