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
    public partial class GetCampaignMessageResponseCompoundDocument : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CampaignMessageResponseObjectResource? Data { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CampaignMessageResponseObjectResource Data { get; set; }
#endif
        /// <summary>The included property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument.GetCampaignMessageResponseCompoundDocument_included>? Included { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument.GetCampaignMessageResponseCompoundDocument_included> Included { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument"/> and sets the default values.
        /// </summary>
        public GetCampaignMessageResponseCompoundDocument()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "data", n => { Data = n.GetObjectValue<global::ApiSdk.Models.CampaignMessageResponseObjectResource>(global::ApiSdk.Models.CampaignMessageResponseObjectResource.CreateFromDiscriminatorValue); } },
                { "included", n => { Included = n.GetCollectionOfObjectValues<global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument.GetCampaignMessageResponseCompoundDocument_included>(global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument.GetCampaignMessageResponseCompoundDocument_included.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.CampaignMessageResponseObjectResource>("data", Data);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument.GetCampaignMessageResponseCompoundDocument_included>("included", Included);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.CampaignResponseObjectResource"/>, <see cref="global::ApiSdk.Models.TemplateResponseObjectResource"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class GetCampaignMessageResponseCompoundDocument_included : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CampaignResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CampaignResponseObjectResource? CampaignResponseObjectResource { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CampaignResponseObjectResource CampaignResponseObjectResource { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.TemplateResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.TemplateResponseObjectResource? TemplateResponseObjectResource { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.TemplateResponseObjectResource TemplateResponseObjectResource { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument.GetCampaignMessageResponseCompoundDocument_included"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument.GetCampaignMessageResponseCompoundDocument_included CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::ApiSdk.Models.GetCampaignMessageResponseCompoundDocument.GetCampaignMessageResponseCompoundDocument_included();
                if("CampaignResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CampaignResponseObjectResource = new global::ApiSdk.Models.CampaignResponseObjectResource();
                }
                else if("TemplateResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.TemplateResponseObjectResource = new global::ApiSdk.Models.TemplateResponseObjectResource();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CampaignResponseObjectResource != null)
                {
                    return CampaignResponseObjectResource.GetFieldDeserializers();
                }
                else if(TemplateResponseObjectResource != null)
                {
                    return TemplateResponseObjectResource.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(CampaignResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.CampaignResponseObjectResource>(null, CampaignResponseObjectResource);
                }
                else if(TemplateResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.TemplateResponseObjectResource>(null, TemplateResponseObjectResource);
                }
            }
        }
    }
}
#pragma warning restore CS0618
