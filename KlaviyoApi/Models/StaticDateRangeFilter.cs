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
    public partial class StaticDateRangeFilter : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The end property</summary>
        public DateTimeOffset? End { get; set; }
        /// <summary>Operators for static date range filters.E.g. &quot;between 2023-01-01 and 2023-02-01&quot;</summary>
        public global::ApiSdk.Models.StaticDateRangeFilter_operator? Operator { get; set; }
        /// <summary>The start property</summary>
        public DateTimeOffset? Start { get; set; }
        /// <summary>The type property</summary>
        public global::ApiSdk.Models.DateEnum? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.StaticDateRangeFilter"/> and sets the default values.
        /// </summary>
        public StaticDateRangeFilter()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.StaticDateRangeFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.StaticDateRangeFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.StaticDateRangeFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "end", n => { End = n.GetDateTimeOffsetValue(); } },
                { "operator", n => { Operator = n.GetEnumValue<global::ApiSdk.Models.StaticDateRangeFilter_operator>(); } },
                { "start", n => { Start = n.GetDateTimeOffsetValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::ApiSdk.Models.DateEnum>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("end", End);
            writer.WriteEnumValue<global::ApiSdk.Models.StaticDateRangeFilter_operator>("operator", Operator);
            writer.WriteDateTimeOffsetValue("start", Start);
            writer.WriteEnumValue<global::ApiSdk.Models.DateEnum>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
