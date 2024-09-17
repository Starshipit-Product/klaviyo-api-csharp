// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Api.Events.Item.Metric;
using ApiSdk.Api.Events.Item.Profile;
using ApiSdk.Api.Events.Item.Relationships;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Api.Events.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\events\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class EventsItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The metric property</summary>
        public global::ApiSdk.Api.Events.Item.Metric.MetricRequestBuilder Metric
        {
            get => new global::ApiSdk.Api.Events.Item.Metric.MetricRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profile property</summary>
        public global::ApiSdk.Api.Events.Item.Profile.ProfileRequestBuilder Profile
        {
            get => new global::ApiSdk.Api.Events.Item.Profile.ProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The relationships property</summary>
        public global::ApiSdk.Api.Events.Item.Relationships.RelationshipsRequestBuilder Relationships
        {
            get => new global::ApiSdk.Api.Events.Item.Relationships.RelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Events.Item.EventsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/events/{id}{?fields%5Bevent%5D,fields%5Bmetric%5D,fields%5Bprofile%5D,include}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Events.Item.EventsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/events/{id}{?fields%5Bevent%5D,fields%5Bmetric%5D,fields%5Bprofile%5D,include}", rawUrl)
        {
        }
        /// <summary>
        /// Get an event with the given event ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`events:read`
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GetEventResponseCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.GetEventResponseCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::ApiSdk.Models.GetEventResponseCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.GetEventResponseCompoundDocument?> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Events.Item.EventsItemRequestBuilder.EventsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.GetEventResponseCompoundDocument> GetAsync(Action<RequestConfiguration<global::ApiSdk.Api.Events.Item.EventsItemRequestBuilder.EventsItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::ApiSdk.Models.GetEventResponseCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::ApiSdk.Models.GetEventResponseCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.GetEventResponseCompoundDocument>(requestInfo, global::ApiSdk.Models.GetEventResponseCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get an event with the given event ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`events:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Events.Item.EventsItemRequestBuilder.EventsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.Api.Events.Item.EventsItemRequestBuilder.EventsItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::ApiSdk.Api.Events.Item.EventsItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.Api.Events.Item.EventsItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.Api.Events.Item.EventsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get an event with the given event ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`events:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EventsItemRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldseventAsGetFieldsEventQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bevent%5D")]
            public string[]? Fieldsevent { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bevent%5D")]
            public string[] Fieldsevent { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bevent%5D")]
            public global::ApiSdk.Api.Events.Item.GetFieldsEventQueryParameterType[]? FieldseventAsGetFieldsEventQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bevent%5D")]
            public global::ApiSdk.Api.Events.Item.GetFieldsEventQueryParameterType[] FieldseventAsGetFieldsEventQueryParameterType { get; set; }
#endif
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
            public global::ApiSdk.Api.Events.Item.GetFieldsMetricQueryParameterType[]? FieldsmetricAsGetFieldsMetricQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bmetric%5D")]
            public global::ApiSdk.Api.Events.Item.GetFieldsMetricQueryParameterType[] FieldsmetricAsGetFieldsMetricQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsprofileAsGetFieldsProfileQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bprofile%5D")]
            public string[]? Fieldsprofile { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bprofile%5D")]
            public string[] Fieldsprofile { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bprofile%5D")]
            public global::ApiSdk.Api.Events.Item.GetFieldsProfileQueryParameterType[]? FieldsprofileAsGetFieldsProfileQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bprofile%5D")]
            public global::ApiSdk.Api.Events.Item.GetFieldsProfileQueryParameterType[] FieldsprofileAsGetFieldsProfileQueryParameterType { get; set; }
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
            public global::ApiSdk.Api.Events.Item.GetIncludeQueryParameterType[]? IncludeAsGetIncludeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public global::ApiSdk.Api.Events.Item.GetIncludeQueryParameterType[] IncludeAsGetIncludeQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EventsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ApiSdk.Api.Events.Item.EventsItemRequestBuilder.EventsItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
