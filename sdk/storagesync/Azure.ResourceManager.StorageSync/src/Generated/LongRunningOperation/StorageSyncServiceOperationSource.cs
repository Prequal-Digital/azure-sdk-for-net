// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync
{
    internal class StorageSyncServiceOperationSource : IOperationSource<StorageSyncServiceResource>
    {
        private readonly ArmClient _client;

        internal StorageSyncServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        StorageSyncServiceResource IOperationSource<StorageSyncServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StorageSyncServiceData.DeserializeStorageSyncServiceData(document.RootElement);
            return new StorageSyncServiceResource(_client, data);
        }

        async ValueTask<StorageSyncServiceResource> IOperationSource<StorageSyncServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StorageSyncServiceData.DeserializeStorageSyncServiceData(document.RootElement);
            return new StorageSyncServiceResource(_client, data);
        }
    }
}
