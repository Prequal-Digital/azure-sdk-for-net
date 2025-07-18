// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    internal class FaultSimulationOperationSource : IOperationSource<FaultSimulation>
    {
        FaultSimulation IOperationSource<FaultSimulation>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return FaultSimulation.DeserializeFaultSimulation(document.RootElement);
        }

        async ValueTask<FaultSimulation> IOperationSource<FaultSimulation>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return FaultSimulation.DeserializeFaultSimulation(document.RootElement);
        }
    }
}
