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
namespace ApiSdk.Api.CampaignRecipientEstimations.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\campaign-recipient-estimations\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class CampaignRecipientEstimationsItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.CampaignRecipientEstimations.Item.CampaignRecipientEstimationsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CampaignRecipientEstimationsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/campaign-recipient-estimations/{id}{?fields%5Bcampaign%2Drecipient%2Destimation%5D}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.CampaignRecipientEstimations.Item.CampaignRecipientEstimationsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CampaignRecipientEstimationsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/campaign-recipient-estimations/{id}{?fields%5Bcampaign%2Drecipient%2Destimation%5D}", rawUrl)
        {
        }
        /// <summary>
        /// Get the estimated recipient count for a campaign with the provided campaign ID.You can refresh this count by using the `Create Campaign Recipient Estimation Job` endpoint.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`campaigns:read`
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GetCampaignRecipientEstimationResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.GetCampaignRecipientEstimationResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::ApiSdk.Models.GetCampaignRecipientEstimationResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.GetCampaignRecipientEstimationResponse?> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.CampaignRecipientEstimations.Item.CampaignRecipientEstimationsItemRequestBuilder.CampaignRecipientEstimationsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.GetCampaignRecipientEstimationResponse> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.CampaignRecipientEstimations.Item.CampaignRecipientEstimationsItemRequestBuilder.CampaignRecipientEstimationsItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::ApiSdk.Models.GetCampaignRecipientEstimationResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::ApiSdk.Models.GetCampaignRecipientEstimationResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.GetCampaignRecipientEstimationResponse>(requestInfo, global::ApiSdk.Models.GetCampaignRecipientEstimationResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the estimated recipient count for a campaign with the provided campaign ID.You can refresh this count by using the `Create Campaign Recipient Estimation Job` endpoint.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`campaigns:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.CampaignRecipientEstimations.Item.CampaignRecipientEstimationsItemRequestBuilder.CampaignRecipientEstimationsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.CampaignRecipientEstimations.Item.CampaignRecipientEstimationsItemRequestBuilder.CampaignRecipientEstimationsItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::ApiSdk.Api.CampaignRecipientEstimations.Item.CampaignRecipientEstimationsItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.Api.CampaignRecipientEstimations.Item.CampaignRecipientEstimationsItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.Api.CampaignRecipientEstimations.Item.CampaignRecipientEstimationsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the estimated recipient count for a campaign with the provided campaign ID.You can refresh this count by using the `Create Campaign Recipient Estimation Job` endpoint.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`campaigns:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class CampaignRecipientEstimationsItemRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldscampaignRecipientEstimationAsGetFieldsCampaignRecipientEstimationQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bcampaign%2Drecipient%2Destimation%5D")]
            public string[]? FieldscampaignRecipientEstimation { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bcampaign%2Drecipient%2Destimation%5D")]
            public string[] FieldscampaignRecipientEstimation { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bcampaign%2Drecipient%2Destimation%5D")]
            public global::ApiSdk.Api.CampaignRecipientEstimations.Item.GetFieldsCampaignRecipientEstimationQueryParameterType[]? FieldscampaignRecipientEstimationAsGetFieldsCampaignRecipientEstimationQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bcampaign%2Drecipient%2Destimation%5D")]
            public global::ApiSdk.Api.CampaignRecipientEstimations.Item.GetFieldsCampaignRecipientEstimationQueryParameterType[] FieldscampaignRecipientEstimationAsGetFieldsCampaignRecipientEstimationQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class CampaignRecipientEstimationsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ApiSdk.Api.CampaignRecipientEstimations.Item.CampaignRecipientEstimationsItemRequestBuilder.CampaignRecipientEstimationsItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
