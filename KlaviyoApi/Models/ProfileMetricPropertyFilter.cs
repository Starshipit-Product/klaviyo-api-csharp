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
    public partial class ProfileMetricPropertyFilter : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The filter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ProfileMetricPropertyFilter.ProfileMetricPropertyFilter_filter? Filter { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ProfileMetricPropertyFilter.ProfileMetricPropertyFilter_filter Filter { get; set; }
#endif
        /// <summary>The property property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Property { get; set; }
#nullable restore
#else
        public string Property { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ProfileMetricPropertyFilter"/> and sets the default values.
        /// </summary>
        public ProfileMetricPropertyFilter()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ProfileMetricPropertyFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.ProfileMetricPropertyFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ProfileMetricPropertyFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "filter", n => { Filter = n.GetObjectValue<global::ApiSdk.Models.ProfileMetricPropertyFilter.ProfileMetricPropertyFilter_filter>(global::ApiSdk.Models.ProfileMetricPropertyFilter.ProfileMetricPropertyFilter_filter.CreateFromDiscriminatorValue); } },
                { "property", n => { Property = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.ProfileMetricPropertyFilter.ProfileMetricPropertyFilter_filter>("filter", Filter);
            writer.WriteStringValue("property", Property);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.ListLengthFilter"/>, <see cref="global::ApiSdk.Models.ListSetFilter"/>, <see cref="global::ApiSdk.Models.ListSubstringFilter"/>, <see cref="global::ApiSdk.Models.StringArrayOperatorFilter"/>, <see cref="global::ApiSdk.Models.StringOperatorFilter"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ProfileMetricPropertyFilter_filter : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.ListLengthFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.ListLengthFilter? ListLengthFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.ListLengthFilter ListLengthFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.ListSetFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.ListSetFilter? ListSetFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.ListSetFilter ListSetFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.ListSubstringFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.ListSubstringFilter? ListSubstringFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.ListSubstringFilter ListSubstringFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.StringArrayOperatorFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.StringArrayOperatorFilter? StringArrayOperatorFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.StringArrayOperatorFilter StringArrayOperatorFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.StringOperatorFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.StringOperatorFilter? StringOperatorFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.StringOperatorFilter StringOperatorFilter { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.ProfileMetricPropertyFilter.ProfileMetricPropertyFilter_filter"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.ProfileMetricPropertyFilter.ProfileMetricPropertyFilter_filter CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::ApiSdk.Models.ProfileMetricPropertyFilter.ProfileMetricPropertyFilter_filter();
                if("ListLengthFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ListLengthFilter = new global::ApiSdk.Models.ListLengthFilter();
                }
                else if("ListSetFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ListSetFilter = new global::ApiSdk.Models.ListSetFilter();
                }
                else if("ListSubstringFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ListSubstringFilter = new global::ApiSdk.Models.ListSubstringFilter();
                }
                else if("StringArrayOperatorFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.StringArrayOperatorFilter = new global::ApiSdk.Models.StringArrayOperatorFilter();
                }
                else if("StringOperatorFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.StringOperatorFilter = new global::ApiSdk.Models.StringOperatorFilter();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(ListLengthFilter != null)
                {
                    return ListLengthFilter.GetFieldDeserializers();
                }
                else if(ListSetFilter != null)
                {
                    return ListSetFilter.GetFieldDeserializers();
                }
                else if(ListSubstringFilter != null)
                {
                    return ListSubstringFilter.GetFieldDeserializers();
                }
                else if(StringArrayOperatorFilter != null)
                {
                    return StringArrayOperatorFilter.GetFieldDeserializers();
                }
                else if(StringOperatorFilter != null)
                {
                    return StringOperatorFilter.GetFieldDeserializers();
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
                if(ListLengthFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.ListLengthFilter>(null, ListLengthFilter);
                }
                else if(ListSetFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.ListSetFilter>(null, ListSetFilter);
                }
                else if(ListSubstringFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.ListSubstringFilter>(null, ListSubstringFilter);
                }
                else if(StringArrayOperatorFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.StringArrayOperatorFilter>(null, StringArrayOperatorFilter);
                }
                else if(StringOperatorFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.StringOperatorFilter>(null, StringOperatorFilter);
                }
            }
        }
    }
}
#pragma warning restore CS0618
