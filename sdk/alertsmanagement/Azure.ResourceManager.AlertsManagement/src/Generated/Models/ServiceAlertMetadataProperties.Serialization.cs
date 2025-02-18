// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertMetadataProperties
    {
        internal static ServiceAlertMetadataProperties DeserializeServiceAlertMetadataProperties(JsonElement element)
        {
            if (element.TryGetProperty("metadataIdentifier", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "MonitorServiceList": return MonitorServiceList.DeserializeMonitorServiceList(element);
                }
            }
            ServiceAlertMetadataIdentifier metadataIdentifier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadataIdentifier"))
                {
                    metadataIdentifier = new ServiceAlertMetadataIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownServiceAlertMetadataProperties(metadataIdentifier);
        }
    }
}
