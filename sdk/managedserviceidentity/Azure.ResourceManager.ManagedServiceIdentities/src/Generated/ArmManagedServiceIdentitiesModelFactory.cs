// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServiceIdentities.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmManagedServiceIdentitiesModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ManagedServiceIdentities.SystemAssignedIdentityData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tenantId"> The id of the tenant which the identity belongs to. </param>
        /// <param name="principalId"> The id of the service principal object associated with the created identity. </param>
        /// <param name="clientId"> The id of the app associated with the identity. This is a random generated UUID by MSI. </param>
        /// <param name="clientSecretUri"> The ManagedServiceIdentity DataPlane URL that can be queried to obtain the identity credentials. </param>
        /// <returns> A new <see cref="ManagedServiceIdentities.SystemAssignedIdentityData"/> instance for mocking. </returns>
        public static SystemAssignedIdentityData SystemAssignedIdentityData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, Guid? tenantId = null, Guid? principalId = null, Guid? clientId = null, Uri clientSecretUri = null)
        {
            tags ??= new Dictionary<string, string>();

            return new SystemAssignedIdentityData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                tenantId,
                principalId,
                clientId,
                clientSecretUri,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServiceIdentities.UserAssignedIdentityData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tenantId"> The id of the tenant which the identity belongs to. </param>
        /// <param name="principalId"> The id of the service principal object associated with the created identity. </param>
        /// <param name="clientId"> The id of the app associated with the identity. This is a random generated UUID by MSI. </param>
        /// <param name="isolationScope"> Enum to configure regional restrictions on identity assignment, as necessary. </param>
        /// <returns> A new <see cref="ManagedServiceIdentities.UserAssignedIdentityData"/> instance for mocking. </returns>
        public static UserAssignedIdentityData UserAssignedIdentityData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, Guid? tenantId = null, Guid? principalId = null, Guid? clientId = null, IsolationScope? isolationScope = null)
        {
            tags ??= new Dictionary<string, string>();

            return new UserAssignedIdentityData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                tenantId,
                principalId,
                clientId,
                isolationScope,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.UserAssignedIdentityPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tenantId"> The id of the tenant which the identity belongs to. </param>
        /// <param name="principalId"> The id of the service principal object associated with the created identity. </param>
        /// <param name="clientId"> The id of the app associated with the identity. This is a random generated UUID by MSI. </param>
        /// <param name="isolationScope"> Enum to configure regional restrictions on identity assignment, as necessary. </param>
        /// <returns> A new <see cref="Models.UserAssignedIdentityPatch"/> instance for mocking. </returns>
        public static UserAssignedIdentityPatch UserAssignedIdentityPatch(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, Guid? tenantId = null, Guid? principalId = null, Guid? clientId = null, IsolationScope? isolationScope = null)
        {
            tags ??= new Dictionary<string, string>();

            return new UserAssignedIdentityPatch(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                tenantId,
                principalId,
                clientId,
                isolationScope,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServiceIdentities.FederatedIdentityCredentialData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="issuerUri"> The URL of the issuer to be trusted. </param>
        /// <param name="subject"> The identifier of the external identity. </param>
        /// <param name="audiences"> The list of audiences that can appear in the issued token. </param>
        /// <returns> A new <see cref="ManagedServiceIdentities.FederatedIdentityCredentialData"/> instance for mocking. </returns>
        public static FederatedIdentityCredentialData FederatedIdentityCredentialData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, Uri issuerUri = null, string subject = null, IEnumerable<string> audiences = null)
        {
            audiences ??= new List<string>();

            return new FederatedIdentityCredentialData(
                id,
                name,
                resourceType,
                systemData,
                issuerUri,
                subject,
                audiences?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="T:Azure.ResourceManager.ManagedServiceIdentities.UserAssignedIdentityData" />. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tenantId"> The id of the tenant which the identity belongs to. </param>
        /// <param name="principalId"> The id of the service principal object associated with the created identity. </param>
        /// <param name="clientId"> The id of the app associated with the identity. This is a random generated UUID by MSI. </param>
        /// <returns> A new <see cref="T:Azure.ResourceManager.ManagedServiceIdentities.UserAssignedIdentityData" /> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static UserAssignedIdentityData UserAssignedIdentityData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Guid? tenantId, Guid? principalId, Guid? clientId)
        {
            return UserAssignedIdentityData(id: id, name: name, resourceType: resourceType, systemData: systemData, tags: tags, location: location, tenantId: tenantId, principalId: principalId, clientId: clientId, isolationScope: default);
        }

        /// <summary> Initializes a new instance of <see cref="T:Azure.ResourceManager.ManagedServiceIdentities.Models.UserAssignedIdentityPatch" />. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tenantId"> The id of the tenant which the identity belongs to. </param>
        /// <param name="principalId"> The id of the service principal object associated with the created identity. </param>
        /// <param name="clientId"> The id of the app associated with the identity. This is a random generated UUID by MSI. </param>
        /// <returns> A new <see cref="T:Azure.ResourceManager.ManagedServiceIdentities.Models.UserAssignedIdentityPatch" /> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static UserAssignedIdentityPatch UserAssignedIdentityPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Guid? tenantId, Guid? principalId, Guid? clientId)
        {
            return UserAssignedIdentityPatch(id: id, name: name, resourceType: resourceType, systemData: systemData, tags: tags, location: location, tenantId: tenantId, principalId: principalId, clientId: clientId, isolationScope: default);
        }
    }
}
