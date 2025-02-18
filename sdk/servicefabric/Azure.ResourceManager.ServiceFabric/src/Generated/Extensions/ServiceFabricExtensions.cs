// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ServiceFabric. </summary>
    public static partial class ServiceFabricExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/clusters
        /// Operation Id: Clusters_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ServiceFabricClusterResource> GetServiceFabricClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetServiceFabricClustersAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/clusters
        /// Operation Id: Clusters_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ServiceFabricClusterResource> GetServiceFabricClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetServiceFabricClusters(cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions/{clusterVersion}
        /// Operation Id: ClusterVersions_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            return GetExtensionClient(subscriptionResource).GetClusterVersionsAsync(location, clusterVersion, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions/{clusterVersion}
        /// Operation Id: ClusterVersions_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ClusterCodeVersionsResult> GetClusterVersions(this SubscriptionResource subscriptionResource, AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            return GetExtensionClient(subscriptionResource).GetClusterVersions(location, clusterVersion, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions/{clusterVersion}
        /// Operation Id: ClusterVersions_GetByEnvironment
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironmentAsync(this SubscriptionResource subscriptionResource, AzureLocation location, ClusterVersionsEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            return GetExtensionClient(subscriptionResource).GetClusterVersionsByEnvironmentAsync(location, environment, clusterVersion, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions/{clusterVersion}
        /// Operation Id: ClusterVersions_GetByEnvironment
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironment(this SubscriptionResource subscriptionResource, AzureLocation location, ClusterVersionsEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            return GetExtensionClient(subscriptionResource).GetClusterVersionsByEnvironment(location, environment, clusterVersion, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions
        /// Operation Id: ClusterVersions_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetClusterVersionsAsync(location, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions
        /// Operation Id: ClusterVersions_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ClusterCodeVersionsResult> GetClusterVersions(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetClusterVersions(location, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by environment.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions
        /// Operation Id: ClusterVersions_ListByEnvironment
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironmentAsync(this SubscriptionResource subscriptionResource, AzureLocation location, ClusterVersionsEnvironment environment, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetClusterVersionsByEnvironmentAsync(location, environment, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by environment.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions
        /// Operation Id: ClusterVersions_ListByEnvironment
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironment(this SubscriptionResource subscriptionResource, AzureLocation location, ClusterVersionsEnvironment environment, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetClusterVersionsByEnvironment(location, environment, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ServiceFabricClusterResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ServiceFabricClusterResources and their operations over a ServiceFabricClusterResource. </returns>
        public static ServiceFabricClusterCollection GetServiceFabricClusters(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetServiceFabricClusters();
        }

        /// <summary>
        /// Get a Service Fabric cluster resource created or in the process of being created in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ServiceFabricClusterResource>> GetServiceFabricClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetServiceFabricClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Service Fabric cluster resource created or in the process of being created in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ServiceFabricClusterResource> GetServiceFabricCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetServiceFabricClusters().Get(clusterName, cancellationToken);
        }

        #region ServiceFabricClusterResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricClusterResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricClusterResource" /> object. </returns>
        public static ServiceFabricClusterResource GetServiceFabricClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceFabricClusterResource.ValidateResourceId(id);
                return new ServiceFabricClusterResource(client, id);
            }
            );
        }
        #endregion

        #region ServiceFabricApplicationTypeResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricApplicationTypeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricApplicationTypeResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricApplicationTypeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricApplicationTypeResource" /> object. </returns>
        public static ServiceFabricApplicationTypeResource GetServiceFabricApplicationTypeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceFabricApplicationTypeResource.ValidateResourceId(id);
                return new ServiceFabricApplicationTypeResource(client, id);
            }
            );
        }
        #endregion

        #region ServiceFabricApplicationTypeVersionResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricApplicationTypeVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricApplicationTypeVersionResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricApplicationTypeVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricApplicationTypeVersionResource" /> object. </returns>
        public static ServiceFabricApplicationTypeVersionResource GetServiceFabricApplicationTypeVersionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceFabricApplicationTypeVersionResource.ValidateResourceId(id);
                return new ServiceFabricApplicationTypeVersionResource(client, id);
            }
            );
        }
        #endregion

        #region ServiceFabricApplicationResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricApplicationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricApplicationResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricApplicationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricApplicationResource" /> object. </returns>
        public static ServiceFabricApplicationResource GetServiceFabricApplicationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceFabricApplicationResource.ValidateResourceId(id);
                return new ServiceFabricApplicationResource(client, id);
            }
            );
        }
        #endregion

        #region ServiceFabricServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricServiceResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricServiceResource" /> object. </returns>
        public static ServiceFabricServiceResource GetServiceFabricServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceFabricServiceResource.ValidateResourceId(id);
                return new ServiceFabricServiceResource(client, id);
            }
            );
        }
        #endregion
    }
}
