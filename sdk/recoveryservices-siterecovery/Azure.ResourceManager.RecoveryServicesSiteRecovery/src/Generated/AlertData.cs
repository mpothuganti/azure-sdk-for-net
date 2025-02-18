// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary> A class representing the Alert data model. </summary>
    public partial class AlertData : ResourceData
    {
        /// <summary> Initializes a new instance of AlertData. </summary>
        internal AlertData()
        {
        }

        /// <summary> Initializes a new instance of AlertData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Alert related data. </param>
        /// <param name="location"> Resource Location. </param>
        internal AlertData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertProperties properties, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
        }

        /// <summary> Alert related data. </summary>
        public AlertProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}
