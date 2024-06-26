// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MigrationDiscoverySap
{
    internal class SapInstanceOperationSource : IOperationSource<SapInstanceResource>
    {
        private readonly ArmClient _client;

        internal SapInstanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SapInstanceResource IOperationSource<SapInstanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SapInstanceData.DeserializeSapInstanceData(document.RootElement);
            return new SapInstanceResource(_client, data);
        }

        async ValueTask<SapInstanceResource> IOperationSource<SapInstanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SapInstanceData.DeserializeSapInstanceData(document.RootElement);
            return new SapInstanceResource(_client, data);
        }
    }
}
