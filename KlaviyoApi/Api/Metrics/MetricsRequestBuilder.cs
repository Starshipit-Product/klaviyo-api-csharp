// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Api.Metrics.Item;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Api.Metrics
{
    /// <summary>
    /// Builds and executes requests for operations under \api\metrics
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class MetricsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the ApiSdk.api.metrics.item collection</summary>
        /// <param name="position">Metric ID</param>
        /// <returns>A <see cref="global::ApiSdk.Api.Metrics.Item.MetricsItemRequestBuilder"/></returns>
        public global::ApiSdk.Api.Metrics.Item.MetricsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::ApiSdk.Api.Metrics.Item.MetricsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Metrics.MetricsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MetricsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/metrics{?fields%5Bmetric%5D,filter*,page%5Bcursor%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Metrics.MetricsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MetricsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/metrics{?fields%5Bmetric%5D,filter*,page%5Bcursor%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Get all metrics in an account.Requests can be filtered by the following fields:integration `name`, integration `category`Returns a maximum of 200 results per page.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`metrics:read`
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GetMetricResponseCollectionCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.GetMetricResponseCollectionCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::ApiSdk.Models.GetMetricResponseCollectionCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.GetMetricResponseCollectionCompoundDocument?> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Metrics.MetricsRequestBuilder.MetricsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.GetMetricResponseCollectionCompoundDocument> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Metrics.MetricsRequestBuilder.MetricsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::ApiSdk.Models.GetMetricResponseCollectionCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::ApiSdk.Models.GetMetricResponseCollectionCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.GetMetricResponseCollectionCompoundDocument>(requestInfo, global::ApiSdk.Models.GetMetricResponseCollectionCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all metrics in an account.Requests can be filtered by the following fields:integration `name`, integration `category`Returns a maximum of 200 results per page.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`metrics:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Metrics.MetricsRequestBuilder.MetricsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Metrics.MetricsRequestBuilder.MetricsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::ApiSdk.Api.Metrics.MetricsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.Api.Metrics.MetricsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.Api.Metrics.MetricsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all metrics in an account.Requests can be filtered by the following fields:integration `name`, integration `category`Returns a maximum of 200 results per page.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`metrics:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class MetricsRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsmetricAsGetFieldsMetricQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bmetric%5D")]
            public string[]? Fieldsmetric { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bmetric%5D")]
            public string[] Fieldsmetric { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bmetric%5D")]
            public global::ApiSdk.Api.Metrics.GetFieldsMetricQueryParameterType[]? FieldsmetricAsGetFieldsMetricQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bmetric%5D")]
            public global::ApiSdk.Api.Metrics.GetFieldsMetricQueryParameterType[] FieldsmetricAsGetFieldsMetricQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#filtering&lt;br&gt;Allowed field(s)/operator(s):&lt;br&gt;`integration.name`: `equals`&lt;br&gt;`integration.category`: `equals`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("filter")]
            public string Filter { get; set; }
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class MetricsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ApiSdk.Api.Metrics.MetricsRequestBuilder.MetricsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
