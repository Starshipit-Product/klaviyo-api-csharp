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
    public partial class CatalogCategoryCreateJobCreateQueryResourceObject : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CatalogCategoryCreateJobCreateQueryResourceObject_attributes? Attributes { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CatalogCategoryCreateJobCreateQueryResourceObject_attributes Attributes { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::ApiSdk.Models.CatalogCategoryBulkCreateJobEnum? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.CatalogCategoryCreateJobCreateQueryResourceObject"/> and sets the default values.
        /// </summary>
        public CatalogCategoryCreateJobCreateQueryResourceObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CatalogCategoryCreateJobCreateQueryResourceObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.CatalogCategoryCreateJobCreateQueryResourceObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CatalogCategoryCreateJobCreateQueryResourceObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attributes", n => { Attributes = n.GetObjectValue<global::ApiSdk.Models.CatalogCategoryCreateJobCreateQueryResourceObject_attributes>(global::ApiSdk.Models.CatalogCategoryCreateJobCreateQueryResourceObject_attributes.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::ApiSdk.Models.CatalogCategoryBulkCreateJobEnum>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.CatalogCategoryCreateJobCreateQueryResourceObject_attributes>("attributes", Attributes);
            writer.WriteEnumValue<global::ApiSdk.Models.CatalogCategoryBulkCreateJobEnum>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
