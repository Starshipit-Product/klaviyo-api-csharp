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
namespace ApiSdk.Client.Subscriptions
{
    /// <summary>
    /// Builds and executes requests for operations under \client\subscriptions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class SubscriptionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Client.Subscriptions.SubscriptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubscriptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/client/subscriptions?company_id={company_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Client.Subscriptions.SubscriptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubscriptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/client/subscriptions?company_id={company_id}", rawUrl)
        {
        }
        /// <summary>
        /// Creates a subscription and consent record for email and/or SMS channels based on the provided `email` and `phone_number` attributes, respectively. One of either `email` or `phone_number` must be provided.This endpoint is specifically designed to be called from publicly-browseable, client-side environments only and requires a [public API key (site ID)](https://www.klaviyo.com/settings/account/api-keys). Never use a private API key with our client-side endpoints.To subscribe profiles from server-side applications, please use [POST /api/profile-subscription-bulk-create-jobs](https://developers.klaviyo.com/en/reference/subscribe_profiles).To create a subscription and consent record for only 1 channel but still include the other channel as a profile property, the consent channel can be provided as a top-level attribute and the other channel can be included in the properties object.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `100/s`&lt;br&gt;Steady: `700/m`**Scopes:**`subscriptions:write`
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::ApiSdk.Models.OnsiteSubscriptionCreateQuery body, Action<RequestConfiguration<global::ApiSdk.Client.Subscriptions.SubscriptionsRequestBuilder.SubscriptionsRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::ApiSdk.Models.OnsiteSubscriptionCreateQuery body, Action<RequestConfiguration<global::ApiSdk.Client.Subscriptions.SubscriptionsRequestBuilder.SubscriptionsRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a subscription and consent record for email and/or SMS channels based on the provided `email` and `phone_number` attributes, respectively. One of either `email` or `phone_number` must be provided.This endpoint is specifically designed to be called from publicly-browseable, client-side environments only and requires a [public API key (site ID)](https://www.klaviyo.com/settings/account/api-keys). Never use a private API key with our client-side endpoints.To subscribe profiles from server-side applications, please use [POST /api/profile-subscription-bulk-create-jobs](https://developers.klaviyo.com/en/reference/subscribe_profiles).To create a subscription and consent record for only 1 channel but still include the other channel as a profile property, the consent channel can be provided as a top-level attribute and the other channel can be included in the properties object.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `100/s`&lt;br&gt;Steady: `700/m`**Scopes:**`subscriptions:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Models.OnsiteSubscriptionCreateQuery body, Action<RequestConfiguration<global::ApiSdk.Client.Subscriptions.SubscriptionsRequestBuilder.SubscriptionsRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Models.OnsiteSubscriptionCreateQuery body, Action<RequestConfiguration<global::ApiSdk.Client.Subscriptions.SubscriptionsRequestBuilder.SubscriptionsRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Client.Subscriptions.SubscriptionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.Client.Subscriptions.SubscriptionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.Client.Subscriptions.SubscriptionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Creates a subscription and consent record for email and/or SMS channels based on the provided `email` and `phone_number` attributes, respectively. One of either `email` or `phone_number` must be provided.This endpoint is specifically designed to be called from publicly-browseable, client-side environments only and requires a [public API key (site ID)](https://www.klaviyo.com/settings/account/api-keys). Never use a private API key with our client-side endpoints.To subscribe profiles from server-side applications, please use [POST /api/profile-subscription-bulk-create-jobs](https://developers.klaviyo.com/en/reference/subscribe_profiles).To create a subscription and consent record for only 1 channel but still include the other channel as a profile property, the consent channel can be provided as a top-level attribute and the other channel can be included in the properties object.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `100/s`&lt;br&gt;Steady: `700/m`**Scopes:**`subscriptions:write`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class SubscriptionsRequestBuilderPostQueryParameters 
        {
            /// <summary>Your Public API Key / Site ID. See [this article](https://help.klaviyo.com/hc/en-us/articles/115005062267) for more details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("company_id")]
            public string? CompanyId { get; set; }
#nullable restore
#else
            [QueryParameter("company_id")]
            public string CompanyId { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class SubscriptionsRequestBuilderPostRequestConfiguration : RequestConfiguration<global::ApiSdk.Client.Subscriptions.SubscriptionsRequestBuilder.SubscriptionsRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
