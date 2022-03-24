// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridConnectivity.Tests.Helpers
{
    [ClientTestFixture]
    public class HybridConnectivityTestBase : ManagementRecordedTestBase<hybridconnectivityManagementTestEnvironment>
    {
        protected AzureLocation DefaultLocation => AzureLocation.WestUS2;
        protected ArmClient Client { get; private set; }
        protected Subscription DefaultSubscription { get; private set; }

        protected HybridConnectivityTestBase(bool isAsync, RecordedTestMode mode) : base(isAsync, mode) { }

        protected HybridConnectivityTestBase(bool isAsync) : base(isAsync){ }

        [SetUp]
        public async Task CreateCommonClient()
        {
            Client = GetArmClient();
            DefaultSubscription = await Client.GetDefaultSubscriptionAsync().ConfigureAwait(false);
        }

        /*protected async Task<EndpointResource> createEndPointResourceAsync()
        {
            EndpointResourceData endpointResourceData = new EndpointResourceData();
            endpointResourceData.ResourceId = EndpointResource.CreateResourceIdentifier("", "default");
            endpointResourceData.EndpointType = Models.EndpointType.Default;
            ArmOperation<EndpointResource> endpoint = await DefaultSubscription.GetEndpointResources().CreateOrUpdateAsync(
                WaitUntil.Completed,
                "default",
                endpointResourceData);
            return endpoint.Value;
        }*/

        protected async Task<ResourceGroup> CreateResourceGroupAsync()
        {
            var resourceGroupName = Recording.GenerateAssetName("testConnectedHybridConnectivityRG-");
            var rgOp = await DefaultSubscription.GetResourceGroups().CreateOrUpdateAsync(
                WaitUntil.Completed,
                resourceGroupName,
                new ResourceGroupData(DefaultLocation)
                {
                    Tags =
                    {
                        { "test", "env" }
                    }
                });
            return rgOp.Value;
        }
    }
}
