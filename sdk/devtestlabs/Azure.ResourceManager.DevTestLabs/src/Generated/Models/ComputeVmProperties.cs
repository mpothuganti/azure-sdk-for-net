// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of a virtual machine returned by the Microsoft.Compute API. </summary>
    public partial class ComputeVmProperties
    {
        /// <summary> Initializes a new instance of ComputeVmProperties. </summary>
        internal ComputeVmProperties()
        {
            Statuses = new ChangeTrackingList<ComputeVmInstanceViewStatus>();
            DataDiskIds = new ChangeTrackingList<string>();
            DataDisks = new ChangeTrackingList<ComputeDataDisk>();
        }

        /// <summary> Initializes a new instance of ComputeVmProperties. </summary>
        /// <param name="statuses"> Gets the statuses of the virtual machine. </param>
        /// <param name="osType"> Gets the OS type of the virtual machine. </param>
        /// <param name="vmSize"> Gets the size of the virtual machine. </param>
        /// <param name="networkInterfaceId"> Gets the network interface ID of the virtual machine. </param>
        /// <param name="osDiskId"> Gets OS disk blob uri for the virtual machine. </param>
        /// <param name="dataDiskIds"> Gets data disks blob uri for the virtual machine. </param>
        /// <param name="dataDisks"> Gets all data disks attached to the virtual machine. </param>
        internal ComputeVmProperties(IReadOnlyList<ComputeVmInstanceViewStatus> statuses, string osType, string vmSize, string networkInterfaceId, string osDiskId, IReadOnlyList<string> dataDiskIds, IReadOnlyList<ComputeDataDisk> dataDisks)
        {
            Statuses = statuses;
            OSType = osType;
            VmSize = vmSize;
            NetworkInterfaceId = networkInterfaceId;
            OSDiskId = osDiskId;
            DataDiskIds = dataDiskIds;
            DataDisks = dataDisks;
        }

        /// <summary> Gets the statuses of the virtual machine. </summary>
        public IReadOnlyList<ComputeVmInstanceViewStatus> Statuses { get; }
        /// <summary> Gets the OS type of the virtual machine. </summary>
        public string OSType { get; }
        /// <summary> Gets the size of the virtual machine. </summary>
        public string VmSize { get; }
        /// <summary> Gets the network interface ID of the virtual machine. </summary>
        public string NetworkInterfaceId { get; }
        /// <summary> Gets OS disk blob uri for the virtual machine. </summary>
        public string OSDiskId { get; }
        /// <summary> Gets data disks blob uri for the virtual machine. </summary>
        public IReadOnlyList<string> DataDiskIds { get; }
        /// <summary> Gets all data disks attached to the virtual machine. </summary>
        public IReadOnlyList<ComputeDataDisk> DataDisks { get; }
    }
}
