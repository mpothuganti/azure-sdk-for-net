// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;

namespace Azure.ResourceManager.HybridConnectivity.Tests.Helpers
{
    internal static class TestHelper
    {
        /// <summary>
        /// Default constructor for management clients, using the TestSupport Infrastructure
        /// </summary>
        /// <param name="testBase">the test class</param>
        /// <param name="context"></param>
        /// <returns>A resource management client, created from the current context (environment variables)</returns>
        public static ArmResourceExtensionClient GetHybridConnectivityManagementClient(this TestBase testBase, MockContext context)
        {
            return context.GetServiceClient<ArmResourceExtensionClient>();
        }
    }
}
