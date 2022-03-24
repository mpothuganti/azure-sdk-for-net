// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.ResourceManager.HybridConnectivity.Tests.Helpers;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Xunit;

namespace Azure.ResourceManager.HybridConnectivity.Tests
{
    public class SampleTest : TestBase
    {
        private const string resourceURI = "/subscriptions/1c70e365-4937-4ff9-8524-262064a268d8/resourceGroups/DotnetSDKTest/providers/Microsoft.HybridCompute/machines/LAPTOP-HDUMCR3M";

        [Fact]
        public void EndPoints_CreateOrUpdateEndpoint()
        {
            using (MockContext context = MockContext.Start(GetType().FullName))
            {
                ArmResourceExtensionClient client = this.GetHybridConnectivityManagementClient(context);
                EndpointResourceData endpointResourceData = new EndpointResourceData();
                endpointResourceData.ResourceId = EndpointResource.CreateResourceIdentifier(resourceURI, "default");
                client.GetEndpointResources().CreateOrUpdate(Azure.WaitUntil.Completed, "default", endpointResourceData);
                Assert.True(true);
            }
        }
    }
}
