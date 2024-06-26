// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class NetworkFabricIPExtendedCommunityOperationSource : IOperationSource<NetworkFabricIPExtendedCommunityResource>
    {
        private readonly ArmClient _client;

        internal NetworkFabricIPExtendedCommunityOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFabricIPExtendedCommunityResource IOperationSource<NetworkFabricIPExtendedCommunityResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkFabricIPExtendedCommunityData.DeserializeNetworkFabricIPExtendedCommunityData(document.RootElement);
            return new NetworkFabricIPExtendedCommunityResource(_client, data);
        }

        async ValueTask<NetworkFabricIPExtendedCommunityResource> IOperationSource<NetworkFabricIPExtendedCommunityResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkFabricIPExtendedCommunityData.DeserializeNetworkFabricIPExtendedCommunityData(document.RootElement);
            return new NetworkFabricIPExtendedCommunityResource(_client, data);
        }
    }
}
