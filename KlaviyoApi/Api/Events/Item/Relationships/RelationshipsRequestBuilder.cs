// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Api.Events.Item.Relationships.Metric;
using ApiSdk.Api.Events.Item.Relationships.Profile;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace ApiSdk.Api.Events.Item.Relationships
{
    /// <summary>
    /// Builds and executes requests for operations under \api\events\{id}\relationships
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RelationshipsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The metric property</summary>
        public global::ApiSdk.Api.Events.Item.Relationships.Metric.MetricRequestBuilder Metric
        {
            get => new global::ApiSdk.Api.Events.Item.Relationships.Metric.MetricRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profile property</summary>
        public global::ApiSdk.Api.Events.Item.Relationships.Profile.ProfileRequestBuilder Profile
        {
            get => new global::ApiSdk.Api.Events.Item.Relationships.Profile.ProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Events.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/events/{id}/relationships", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Events.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/events/{id}/relationships", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
