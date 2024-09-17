// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Api.Lists.Item;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Api.Lists
{
    /// <summary>
    /// Builds and executes requests for operations under \api\lists
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ListsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the ApiSdk.api.lists.item collection</summary>
        /// <param name="position">Primary key that uniquely identifies this list. Generated by Klaviyo.</param>
        /// <returns>A <see cref="global::ApiSdk.Api.Lists.Item.ListsItemRequestBuilder"/></returns>
        public global::ApiSdk.Api.Lists.Item.ListsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::ApiSdk.Api.Lists.Item.ListsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Lists.ListsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/lists{?fields%5Blist%5D,fields%5Btag%5D,filter*,include,page%5Bcursor%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Lists.ListsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/lists{?fields%5Blist%5D,fields%5Btag%5D,filter*,include,page%5Bcursor%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Get all lists in an account.Filter to request a subset of all lists. Lists can be filtered by `id`, `name`, `created`, and `updated` fields.Returns a maximum of 10 results per page.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`lists:read`
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GetListListResponseCollectionCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.GetListListResponseCollectionCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::ApiSdk.Models.GetListListResponseCollectionCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.GetListListResponseCollectionCompoundDocument?> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Lists.ListsRequestBuilder.ListsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.GetListListResponseCollectionCompoundDocument> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Lists.ListsRequestBuilder.ListsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::ApiSdk.Models.GetListListResponseCollectionCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::ApiSdk.Models.GetListListResponseCollectionCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.GetListListResponseCollectionCompoundDocument>(requestInfo, global::ApiSdk.Models.GetListListResponseCollectionCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new list.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`&lt;br&gt;Daily: `100/d`**Scopes:**`lists:write`
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PostListCreateResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.PostListCreateResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::ApiSdk.Models.PostListCreateResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.PostListCreateResponse?> PostAsync(global::ApiSdk.Models.ListCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.PostListCreateResponse> PostAsync(global::ApiSdk.Models.ListCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::ApiSdk.Models.PostListCreateResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::ApiSdk.Models.PostListCreateResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.PostListCreateResponse>(requestInfo, global::ApiSdk.Models.PostListCreateResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all lists in an account.Filter to request a subset of all lists. Lists can be filtered by `id`, `name`, `created`, and `updated` fields.Returns a maximum of 10 results per page.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`lists:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Lists.ListsRequestBuilder.ListsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Lists.ListsRequestBuilder.ListsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new list.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`&lt;br&gt;Daily: `100/d`**Scopes:**`lists:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Models.ListCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Models.ListCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Api.Lists.ListsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.Api.Lists.ListsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.Api.Lists.ListsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all lists in an account.Filter to request a subset of all lists. Lists can be filtered by `id`, `name`, `created`, and `updated` fields.Returns a maximum of 10 results per page.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`lists:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ListsRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldslistAsGetFieldsListQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Blist%5D")]
            public string[]? Fieldslist { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Blist%5D")]
            public string[] Fieldslist { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Blist%5D")]
            public global::ApiSdk.Api.Lists.GetFieldsListQueryParameterType[]? FieldslistAsGetFieldsListQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Blist%5D")]
            public global::ApiSdk.Api.Lists.GetFieldsListQueryParameterType[] FieldslistAsGetFieldsListQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldstagAsGetFieldsTagQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Btag%5D")]
            public string[]? Fieldstag { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Btag%5D")]
            public string[] Fieldstag { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Btag%5D")]
            public global::ApiSdk.Api.Lists.GetFieldsTagQueryParameterType[]? FieldstagAsGetFieldsTagQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Btag%5D")]
            public global::ApiSdk.Api.Lists.GetFieldsTagQueryParameterType[] FieldstagAsGetFieldsTagQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#filtering&lt;br&gt;Allowed field(s)/operator(s):&lt;br&gt;`name`: `any`, `equals`&lt;br&gt;`id`: `any`, `equals`&lt;br&gt;`created`: `greater-than`&lt;br&gt;`updated`: `greater-than`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("filter")]
            public string Filter { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#relationships</summary>
            [Obsolete("This property is deprecated, use IncludeAsGetIncludeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("include")]
            public string[]? Include { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public string[] Include { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#relationships</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("include")]
            public global::ApiSdk.Api.Lists.GetIncludeQueryParameterType[]? IncludeAsGetIncludeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public global::ApiSdk.Api.Lists.GetIncludeQueryParameterType[] IncludeAsGetIncludeQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#pagination</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page%5Bcursor%5D")]
            public string? Pagecursor { get; set; }
#nullable restore
#else
            [QueryParameter("page%5Bcursor%5D")]
            public string Pagecursor { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sorting</summary>
            [Obsolete("This property is deprecated, use SortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sorting</summary>
            [QueryParameter("sort")]
            public global::ApiSdk.Api.Lists.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ListsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ApiSdk.Api.Lists.ListsRequestBuilder.ListsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ListsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
