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
    public partial class PatchTemplateResponse_data_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date the template was created in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)</summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary>`editor_type` has a fixed set of values:* SYSTEM_DRAGGABLE: indicates a drag-and-drop editor template* SIMPLE: A rich text editor template* CODE: A custom HTML template* USER_DRAGGABLE: A hybrid template, using custom HTML in the drag-and-drop editor</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EditorType { get; set; }
#nullable restore
#else
        public string EditorType { get; set; }
#endif
        /// <summary>The rendered HTML of the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Html { get; set; }
#nullable restore
#else
        public string Html { get; set; }
#endif
        /// <summary>The name of the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The template plain_text</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The date the template was updated in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)</summary>
        public DateTimeOffset? Updated { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.PatchTemplateResponse_data_attributes"/> and sets the default values.
        /// </summary>
        public PatchTemplateResponse_data_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PatchTemplateResponse_data_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.PatchTemplateResponse_data_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PatchTemplateResponse_data_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created", n => { Created = n.GetDateTimeOffsetValue(); } },
                { "editor_type", n => { EditorType = n.GetStringValue(); } },
                { "html", n => { Html = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "text", n => { Text = n.GetStringValue(); } },
                { "updated", n => { Updated = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created", Created);
            writer.WriteStringValue("editor_type", EditorType);
            writer.WriteStringValue("html", Html);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("text", Text);
            writer.WriteDateTimeOffsetValue("updated", Updated);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
