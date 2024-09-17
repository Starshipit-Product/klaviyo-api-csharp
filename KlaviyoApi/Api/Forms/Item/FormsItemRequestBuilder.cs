// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Api.Forms.Item.FormVersions;
using ApiSdk.Api.Forms.Item.Relationships;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Api.Forms.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\forms\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class FormsItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The formVersions property</summary>
        public global::ApiSdk.Api.Forms.Item.FormVersions.FormVersionsRequestBuilder FormVersions
        {
            get => new global::ApiSdk.Api.Forms.Item.FormVersions.FormVersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The relationships property</summary>
        public global::ApiSdk.Api.Forms.Item.Relationships.RelationshipsRequestBuilder Relationships
        {
            get => new global::ApiSdk.Api.Forms.Item.Relationships.RelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Forms.Item.FormsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FormsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/forms/{id}{?fields%5Bform%2Dversion%5D,fields%5Bform%5D,include}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Forms.Item.FormsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FormsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/forms/{id}{?fields%5Bform%2Dversion%5D,fields%5Bform%5D,include}", rawUrl)
        {
        }
        /// <summary>
        /// Get the form with the given ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`forms:read`
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GetFormResponseCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.GetFormResponseCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::ApiSdk.Models.GetFormResponseCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.GetFormResponseCompoundDocument?> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Forms.Item.FormsItemRequestBuilder.FormsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.GetFormResponseCompoundDocument> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Forms.Item.FormsItemRequestBuilder.FormsItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::ApiSdk.Models.GetFormResponseCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::ApiSdk.Models.GetFormResponseCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.GetFormResponseCompoundDocument>(requestInfo, global::ApiSdk.Models.GetFormResponseCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the form with the given ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`forms:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Forms.Item.FormsItemRequestBuilder.FormsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Forms.Item.FormsItemRequestBuilder.FormsItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::ApiSdk.Api.Forms.Item.FormsItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.Api.Forms.Item.FormsItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.Api.Forms.Item.FormsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the form with the given ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`forms:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class FormsItemRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsformAsGetFieldsFormQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bform%5D")]
            public string[]? Fieldsform { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bform%5D")]
            public string[] Fieldsform { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bform%5D")]
            public global::ApiSdk.Api.Forms.Item.GetFieldsFormQueryParameterType[]? FieldsformAsGetFieldsFormQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bform%5D")]
            public global::ApiSdk.Api.Forms.Item.GetFieldsFormQueryParameterType[] FieldsformAsGetFieldsFormQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsformVersionAsGetFieldsFormVersionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bform%2Dversion%5D")]
            public string[]? FieldsformVersion { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bform%2Dversion%5D")]
            public string[] FieldsformVersion { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bform%2Dversion%5D")]
            public global::ApiSdk.Api.Forms.Item.GetFieldsFormVersionQueryParameterType[]? FieldsformVersionAsGetFieldsFormVersionQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bform%2Dversion%5D")]
            public global::ApiSdk.Api.Forms.Item.GetFieldsFormVersionQueryParameterType[] FieldsformVersionAsGetFieldsFormVersionQueryParameterType { get; set; }
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
            public global::ApiSdk.Api.Forms.Item.GetIncludeQueryParameterType[]? IncludeAsGetIncludeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public global::ApiSdk.Api.Forms.Item.GetIncludeQueryParameterType[] IncludeAsGetIncludeQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class FormsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ApiSdk.Api.Forms.Item.FormsItemRequestBuilder.FormsItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
