// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Api.FlowMessages.Item.FlowAction
{
    /// <summary>
    /// Builds and executes requests for operations under \api\flow-messages\{id}\flow-action
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class FlowActionRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.FlowMessages.Item.FlowAction.FlowActionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FlowActionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/flow-messages/{id}/flow-action{?fields%5Bflow%2Daction%5D}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.FlowMessages.Item.FlowAction.FlowActionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FlowActionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/flow-messages/{id}/flow-action{?fields%5Bflow%2Daction%5D}", rawUrl)
        {
        }
        /// <summary>
        /// Get the flow action for a flow message with the given message ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`flows:read`
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GetFlowActionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.GetFlowActionResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::ApiSdk.Models.GetFlowActionResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.GetFlowActionResponse?> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.FlowMessages.Item.FlowAction.FlowActionRequestBuilder.FlowActionRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.GetFlowActionResponse> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.FlowMessages.Item.FlowAction.FlowActionRequestBuilder.FlowActionRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::ApiSdk.Models.GetFlowActionResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::ApiSdk.Models.GetFlowActionResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.GetFlowActionResponse>(requestInfo, global::ApiSdk.Models.GetFlowActionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the flow action for a flow message with the given message ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`flows:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.FlowMessages.Item.FlowAction.FlowActionRequestBuilder.FlowActionRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.FlowMessages.Item.FlowAction.FlowActionRequestBuilder.FlowActionRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::ApiSdk.Api.FlowMessages.Item.FlowAction.FlowActionRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.Api.FlowMessages.Item.FlowAction.FlowActionRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.Api.FlowMessages.Item.FlowAction.FlowActionRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the flow action for a flow message with the given message ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`flows:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class FlowActionRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsflowActionAsGetFieldsFlowActionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%2Daction%5D")]
            public string[]? FieldsflowAction { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%2Daction%5D")]
            public string[] FieldsflowAction { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%2Daction%5D")]
            public global::ApiSdk.Api.FlowMessages.Item.FlowAction.GetFieldsFlowActionQueryParameterType[]? FieldsflowActionAsGetFieldsFlowActionQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%2Daction%5D")]
            public global::ApiSdk.Api.FlowMessages.Item.FlowAction.GetFieldsFlowActionQueryParameterType[] FieldsflowActionAsGetFieldsFlowActionQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class FlowActionRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ApiSdk.Api.FlowMessages.Item.FlowAction.FlowActionRequestBuilder.FlowActionRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
