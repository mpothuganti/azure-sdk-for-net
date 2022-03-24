// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.HybridConnectivity.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridConnectivity.Tests
{
    public class EndPointsOperationsTests : HybridConnectivityTestBase
    {
        private const string ResourceURI = "/subscriptions/1c70e365-4937-4ff9-8524-262064a268d8/resourceGroups/DotnetSDKTest/providers/Microsoft.HybridCompute/machines/LAPTOP-HDUMCR3M";

        public EndPointsOperationsTests(bool isAsync) : base(isAsync)
        {
        }

        private async Task<EndpointResourceCollection> GetEndpointResourceCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetEndpointResources();
        }

        [TestCase]
        [RecordedTest]
        public async Task EndPoints_CreateOrUpdateEndpoint()
        {
            EndpointResourceData endpointResourceData = new EndpointResourceData();
            endpointResourceData.ResourceId = EndpointResource.CreateResourceIdentifier(ResourceURI, "default");
            endpointResourceData.EndpointType = Models.EndpointType.Default;

            EndpointResourceCollection client = await GetEndpointResourceCollectionAsync();
            EndpointResource endpointResource = client.CreateOrUpdate(WaitUntil.Completed, "default", endpointResourceData).Value;
            AssertEndpointResource(endpointResource.Data);
        }

        private void AssertEndpointResource(EndpointResourceData response)
        {
            Assert.Equals(ResourceURI + "/providers/Microsoft.HybridConnectivity/endpoints/default", response.Id);
            Assert.Equals("default", response.Name);
            Assert.Equals("microsoft.hybridconnectivity/endpoints", response.ResourceType);
            Assert.Equals("Succeeded", response.ProvisioningState);
        }
    }
}
