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
namespace ApiSdk.Api.ProfileSubscriptionBulkCreateJobs
{
    /// <summary>
    /// Builds and executes requests for operations under \api\profile-subscription-bulk-create-jobs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ProfileSubscriptionBulkCreateJobsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.ProfileSubscriptionBulkCreateJobs.ProfileSubscriptionBulkCreateJobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfileSubscriptionBulkCreateJobsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/profile-subscription-bulk-create-jobs", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.ProfileSubscriptionBulkCreateJobs.ProfileSubscriptionBulkCreateJobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfileSubscriptionBulkCreateJobsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/profile-subscription-bulk-create-jobs", rawUrl)
        {
        }
        /// <summary>
        /// Subscribe one or more profiles to email marketing, SMS marketing, or both. If the provided list has double opt-in enabled, profiles will receive a message requiring their confirmation before subscribing. Otherwise, profiles will be immediately subscribed without receiving a confirmation message.Learn more about [consent in this guide](https://developers.klaviyo.com/en/docs/collect_email_and_sms_consent_via_api).If a list is not provided, the opt-in process used will be determined by the [account-level default opt-in setting](https://www.klaviyo.com/settings/account/api-keys).To add someone to a list without changing their subscription status, use [Add Profile to List](https://developers.klaviyo.com/en/reference/create_list_relationships).This API will remove any `UNSUBSCRIBE`, `SPAM_REPORT` or `USER_SUPPRESSED` suppressions from the provided profiles. Learn more about [suppressed profiles](https://help.klaviyo.com/hc/en-us/articles/115005246108-Understanding-suppressed-email-profiles#what-is-a-suppressed-profile-1).Maximum number of profiles can be submitted for subscription: 1000This endpoint now supports a `historical_import` flag. If this flag is set `true`, profiles being subscribed will bypass double opt-in emails and be subscribed immediately. They will also bypass any associated &quot;Added to list&quot; flows. This is useful for importing historical data where you have already collected consent. If `historical_import` is set to true, the `consented_at` field is required and must be in the past.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`lists:write``profiles:write``subscriptions:write`
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.ProfileSubscriptionBulkCreateJobs4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::ApiSdk.Models.ProfileSubscriptionBulkCreateJobs5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::ApiSdk.Models.SubscriptionCreateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::ApiSdk.Models.SubscriptionCreateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::ApiSdk.Models.ProfileSubscriptionBulkCreateJobs4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::ApiSdk.Models.ProfileSubscriptionBulkCreateJobs5XXError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Subscribe one or more profiles to email marketing, SMS marketing, or both. If the provided list has double opt-in enabled, profiles will receive a message requiring their confirmation before subscribing. Otherwise, profiles will be immediately subscribed without receiving a confirmation message.Learn more about [consent in this guide](https://developers.klaviyo.com/en/docs/collect_email_and_sms_consent_via_api).If a list is not provided, the opt-in process used will be determined by the [account-level default opt-in setting](https://www.klaviyo.com/settings/account/api-keys).To add someone to a list without changing their subscription status, use [Add Profile to List](https://developers.klaviyo.com/en/reference/create_list_relationships).This API will remove any `UNSUBSCRIBE`, `SPAM_REPORT` or `USER_SUPPRESSED` suppressions from the provided profiles. Learn more about [suppressed profiles](https://help.klaviyo.com/hc/en-us/articles/115005246108-Understanding-suppressed-email-profiles#what-is-a-suppressed-profile-1).Maximum number of profiles can be submitted for subscription: 1000This endpoint now supports a `historical_import` flag. If this flag is set `true`, profiles being subscribed will bypass double opt-in emails and be subscribed immediately. They will also bypass any associated &quot;Added to list&quot; flows. This is useful for importing historical data where you have already collected consent. If `historical_import` is set to true, the `consented_at` field is required and must be in the past.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`lists:write``profiles:write``subscriptions:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Models.SubscriptionCreateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.Models.SubscriptionCreateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::ApiSdk.Api.ProfileSubscriptionBulkCreateJobs.ProfileSubscriptionBulkCreateJobsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.Api.ProfileSubscriptionBulkCreateJobs.ProfileSubscriptionBulkCreateJobsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.Api.ProfileSubscriptionBulkCreateJobs.ProfileSubscriptionBulkCreateJobsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ProfileSubscriptionBulkCreateJobsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
