// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Api.Profiles.Item.Relationships.Lists;
using ApiSdk.Api.Profiles.Item.Relationships.Segments;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace ApiSdk.Api.Profiles.Item.Relationships
{
    /// <summary>
    /// Builds and executes requests for operations under \api\profiles\{id}\relationships
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RelationshipsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The lists property</summary>
        public global::ApiSdk.Api.Profiles.Item.Relationships.Lists.ListsRequestBuilder Lists
        {
            get => new global::ApiSdk.Api.Profiles.Item.Relationships.Lists.ListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The segments property</summary>
        public global::ApiSdk.Api.Profiles.Item.Relationships.Segments.SegmentsRequestBuilder Segments
        {
            get => new global::ApiSdk.Api.Profiles.Item.Relationships.Segments.SegmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Profiles.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/profiles/{id}/relationships", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Api.Profiles.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/profiles/{id}/relationships", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
