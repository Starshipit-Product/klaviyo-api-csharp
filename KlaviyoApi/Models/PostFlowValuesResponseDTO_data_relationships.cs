// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class PostFlowValuesResponseDTO_data_relationships : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The flowMessages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships_flowMessages? FlowMessages { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships_flowMessages FlowMessages { get; set; }
#endif
        /// <summary>The flows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships_flows? Flows { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships_flows Flows { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships"/> and sets the default values.
        /// </summary>
        public PostFlowValuesResponseDTO_data_relationships()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "flow-messages", n => { FlowMessages = n.GetObjectValue<global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships_flowMessages>(global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships_flowMessages.CreateFromDiscriminatorValue); } },
                { "flows", n => { Flows = n.GetObjectValue<global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships_flows>(global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships_flows.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships_flowMessages>("flow-messages", FlowMessages);
            writer.WriteObjectValue<global::ApiSdk.Models.PostFlowValuesResponseDTO_data_relationships_flows>("flows", Flows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
