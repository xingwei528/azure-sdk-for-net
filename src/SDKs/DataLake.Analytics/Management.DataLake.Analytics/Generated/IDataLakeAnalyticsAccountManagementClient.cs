// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Creates an Azure Data Lake Analytics account management client.
    /// </summary>
    public partial interface IDataLakeAnalyticsAccountManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Get subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IComputePoliciesOperations.
        /// </summary>
        IComputePoliciesOperations ComputePolicies { get; }

        /// <summary>
        /// Gets the IFirewallRulesOperations.
        /// </summary>
        IFirewallRulesOperations FirewallRules { get; }

        /// <summary>
        /// Gets the IStorageAccountsOperations.
        /// </summary>
        IStorageAccountsOperations StorageAccounts { get; }

        /// <summary>
        /// Gets the IDataLakeStoreAccountsOperations.
        /// </summary>
        IDataLakeStoreAccountsOperations DataLakeStoreAccounts { get; }

        /// <summary>
        /// Gets the IAccountOperations.
        /// </summary>
        IAccountOperations Account { get; }

    }
}
