// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Api.Accounts.Item;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Api.Accounts
{
    /// <summary>
    /// Builds and executes requests for operations under \api\accounts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class AccountsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the ApiSdk.api.accounts.item collection</summary>
        /// <param name="position">The ID of the account</param>
        /// <returns>A <see cref="global::ApiSdk.Api.Accounts.Item.AccountsItemRequestBuilder"/></returns>
        public global::ApiSdk.Api.Accounts.Item.AccountsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::ApiSdk.Api.Accounts.Item.AccountsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Accounts.AccountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/accounts{?fields%5Baccount%5D}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Accounts.AccountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/accounts{?fields%5Baccount%5D}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve the account(s) associated with a given private API key. This will return 1 account object within the array.You can use this to retrieve account-specific data (contact information, timezone, currency, Public API key, etc.) or test if a Private API Key belongs to the correct account prior to performing subsequent actions with the API.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`accounts:read`
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GetAccountResponseCollection"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.GetAccountResponseCollection4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::ApiSdk.Models.GetAccountResponseCollection5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.GetAccountResponseCollection?> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.GetAccountResponseCollection> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::ApiSdk.Models.GetAccountResponseCollection4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::ApiSdk.Models.GetAccountResponseCollection5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.GetAccountResponseCollection>(requestInfo, global::ApiSdk.Models.GetAccountResponseCollection.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the account(s) associated with a given private API key. This will return 1 account object within the array.You can use this to retrieve account-specific data (contact information, timezone, currency, Public API key, etc.) or test if a Private API Key belongs to the correct account prior to performing subsequent actions with the API.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`accounts:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Api.Accounts.AccountsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.Api.Accounts.AccountsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.Api.Accounts.AccountsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve the account(s) associated with a given private API key. This will return 1 account object within the array.You can use this to retrieve account-specific data (contact information, timezone, currency, Public API key, etc.) or test if a Private API Key belongs to the correct account prior to performing subsequent actions with the API.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`accounts:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class AccountsRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsaccountAsGetFieldsAccountQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Baccount%5D")]
            public string[]? Fieldsaccount { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Baccount%5D")]
            public string[] Fieldsaccount { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Baccount%5D")]
            public global::ApiSdk.Api.Accounts.GetFieldsAccountQueryParameterType[]? FieldsaccountAsGetFieldsAccountQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Baccount%5D")]
            public global::ApiSdk.Api.Accounts.GetFieldsAccountQueryParameterType[] FieldsaccountAsGetFieldsAccountQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class AccountsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ApiSdk.Api.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
