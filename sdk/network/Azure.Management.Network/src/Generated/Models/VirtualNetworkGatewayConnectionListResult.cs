// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for the ListVirtualNetworkGatewayConnections API service call. </summary>
    public partial class VirtualNetworkGatewayConnectionListResult
    {
        /// <summary> Initializes a new instance of VirtualNetworkGatewayConnectionListResult. </summary>
        internal VirtualNetworkGatewayConnectionListResult()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayConnectionListResult. </summary>
        /// <param name="value"> A list of VirtualNetworkGatewayConnection resources that exists in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal VirtualNetworkGatewayConnectionListResult(IReadOnlyList<VirtualNetworkGatewayConnection> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of VirtualNetworkGatewayConnection resources that exists in a resource group. </summary>
        public IReadOnlyList<VirtualNetworkGatewayConnection> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
