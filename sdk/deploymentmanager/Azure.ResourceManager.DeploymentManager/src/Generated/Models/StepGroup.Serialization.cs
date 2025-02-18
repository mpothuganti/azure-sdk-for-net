// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class StepGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsCollectionDefined(DependsOnStepGroups))
            {
                writer.WritePropertyName("dependsOnStepGroups");
                writer.WriteStartArray();
                foreach (var item in DependsOnStepGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PreDeploymentSteps))
            {
                writer.WritePropertyName("preDeploymentSteps");
                writer.WriteStartArray();
                foreach (var item in PreDeploymentSteps)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("deploymentTargetId");
            writer.WriteStringValue(DeploymentTargetId);
            if (Optional.IsCollectionDefined(PostDeploymentSteps))
            {
                writer.WritePropertyName("postDeploymentSteps");
                writer.WriteStartArray();
                foreach (var item in PostDeploymentSteps)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static StepGroup DeserializeStepGroup(JsonElement element)
        {
            string name = default;
            Optional<IList<string>> dependsOnStepGroups = default;
            Optional<IList<PrePostStep>> preDeploymentSteps = default;
            string deploymentTargetId = default;
            Optional<IList<PrePostStep>> postDeploymentSteps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOnStepGroups"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dependsOnStepGroups = array;
                    continue;
                }
                if (property.NameEquals("preDeploymentSteps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PrePostStep> array = new List<PrePostStep>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrePostStep.DeserializePrePostStep(item));
                    }
                    preDeploymentSteps = array;
                    continue;
                }
                if (property.NameEquals("deploymentTargetId"))
                {
                    deploymentTargetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postDeploymentSteps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PrePostStep> array = new List<PrePostStep>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrePostStep.DeserializePrePostStep(item));
                    }
                    postDeploymentSteps = array;
                    continue;
                }
            }
            return new StepGroup(name, Optional.ToList(dependsOnStepGroups), Optional.ToList(preDeploymentSteps), deploymentTargetId, Optional.ToList(postDeploymentSteps));
        }
    }
}
