// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Api.Webhooks.Item;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Api.Webhooks
{
    /// <summary>
    /// Builds and executes requests for operations under \api\webhooks
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WebhooksRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the ApiSdk.api.webhooks.item collection</summary>
        /// <param name="position">The ID of the webhook.</param>
        /// <returns>A <see cref="global::ApiSdk.Api.Webhooks.Item.WebhooksItemRequestBuilder"/></returns>
        public global::ApiSdk.Api.Webhooks.Item.WebhooksItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::ApiSdk.Api.Webhooks.Item.WebhooksItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Webhooks.WebhooksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebhooksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/webhooks{?fields%5Bwebhook%5D,include}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Webhooks.WebhooksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebhooksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/webhooks{?fields%5Bwebhook%5D,include}", rawUrl)
        {
        }
        /// <summary>
        /// Get all webhooks in an account.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`webhooks:read`
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GetWebhookResponseCollectionCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.GetWebhookResponseCollectionCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::ApiSdk.Models.GetWebhookResponseCollectionCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.GetWebhookResponseCollectionCompoundDocument?> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Webhooks.WebhooksRequestBuilder.WebhooksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.GetWebhookResponseCollectionCompoundDocument> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Webhooks.WebhooksRequestBuilder.WebhooksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::ApiSdk.Models.GetWebhookResponseCollectionCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::ApiSdk.Models.GetWebhookResponseCollectionCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.GetWebhookResponseCollectionCompoundDocument>(requestInfo, global::ApiSdk.Models.GetWebhookResponseCollectionCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new Webhook&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`webhooks:write`
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PostWebhookResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.PostWebhookResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::ApiSdk.Models.PostWebhookResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.PostWebhookResponse?> PostAsync(global::ApiSdk.Models.WebhookCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.PostWebhookResponse> PostAsync(global::ApiSdk.Models.WebhookCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::ApiSdk.Models.PostWebhookResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::ApiSdk.Models.PostWebhookResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.PostWebhookResponse>(requestInfo, global::ApiSdk.Models.PostWebhookResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all webhooks in an account.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`webhooks:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Webhooks.WebhooksRequestBuilder.WebhooksRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Webhooks.WebhooksRequestBuilder.WebhooksRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new Webhook&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`webhooks:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Models.WebhookCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Models.WebhookCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::ApiSdk.Api.Webhooks.WebhooksRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.Api.Webhooks.WebhooksRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.Api.Webhooks.WebhooksRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all webhooks in an account.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`webhooks:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class WebhooksRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldswebhookAsGetFieldsWebhookQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bwebhook%5D")]
            public string[]? Fieldswebhook { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bwebhook%5D")]
            public string[] Fieldswebhook { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bwebhook%5D")]
            public global::ApiSdk.Api.Webhooks.GetFieldsWebhookQueryParameterType[]? FieldswebhookAsGetFieldsWebhookQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bwebhook%5D")]
            public global::ApiSdk.Api.Webhooks.GetFieldsWebhookQueryParameterType[] FieldswebhookAsGetFieldsWebhookQueryParameterType { get; set; }
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
            public global::ApiSdk.Api.Webhooks.GetIncludeQueryParameterType[]? IncludeAsGetIncludeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public global::ApiSdk.Api.Webhooks.GetIncludeQueryParameterType[] IncludeAsGetIncludeQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class WebhooksRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ApiSdk.Api.Webhooks.WebhooksRequestBuilder.WebhooksRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class WebhooksRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
