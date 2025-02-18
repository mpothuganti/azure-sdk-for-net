// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Collection of all the workload Profile States for a Premium Managed Environment.. </summary>
    public partial class WorkloadProfileStates : ResourceData
    {
        /// <summary> Initializes a new instance of WorkloadProfileStates. </summary>
        public WorkloadProfileStates()
        {
        }

        /// <summary> Initializes a new instance of WorkloadProfileStates. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Workload Profile resource specific properties. </param>
        internal WorkloadProfileStates(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WorkloadProfileStatesProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Workload Profile resource specific properties. </summary>
        public WorkloadProfileStatesProperties Properties { get; set; }
    }
}
