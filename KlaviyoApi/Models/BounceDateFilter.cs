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
    public partial class BounceDateFilter : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The field property</summary>
        public global::ApiSdk.Models.Bounce_dateEnum? Field { get; set; }
        /// <summary>The filter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.BounceDateFilter.BounceDateFilter_filter? Filter { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.BounceDateFilter.BounceDateFilter_filter Filter { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.BounceDateFilter"/> and sets the default values.
        /// </summary>
        public BounceDateFilter()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.BounceDateFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.BounceDateFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.BounceDateFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "field", n => { Field = n.GetEnumValue<global::ApiSdk.Models.Bounce_dateEnum>(); } },
                { "filter", n => { Filter = n.GetObjectValue<global::ApiSdk.Models.BounceDateFilter.BounceDateFilter_filter>(global::ApiSdk.Models.BounceDateFilter.BounceDateFilter_filter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::ApiSdk.Models.Bounce_dateEnum>("field", Field);
            writer.WriteObjectValue<global::ApiSdk.Models.BounceDateFilter.BounceDateFilter_filter>("filter", Filter);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.AnniversaryDateFilter"/>, <see cref="global::ApiSdk.Models.CalendarDateFilter"/>, <see cref="global::ApiSdk.Models.IsSetExistenceFilter"/>, <see cref="global::ApiSdk.Models.RelativeAnniversaryDateFilter"/>, <see cref="global::ApiSdk.Models.RelativeDateOperatorBaseFilter"/>, <see cref="global::ApiSdk.Models.RelativeDateRangeFilter"/>, <see cref="global::ApiSdk.Models.StaticDateFilter"/>, <see cref="global::ApiSdk.Models.StaticDateRangeFilter"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class BounceDateFilter_filter : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.AnniversaryDateFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.AnniversaryDateFilter? AnniversaryDateFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.AnniversaryDateFilter AnniversaryDateFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CalendarDateFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CalendarDateFilter? CalendarDateFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CalendarDateFilter CalendarDateFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.IsSetExistenceFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.IsSetExistenceFilter? IsSetExistenceFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.IsSetExistenceFilter IsSetExistenceFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.RelativeAnniversaryDateFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.RelativeAnniversaryDateFilter? RelativeAnniversaryDateFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.RelativeAnniversaryDateFilter RelativeAnniversaryDateFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.RelativeDateOperatorBaseFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.RelativeDateOperatorBaseFilter? RelativeDateOperatorBaseFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.RelativeDateOperatorBaseFilter RelativeDateOperatorBaseFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.RelativeDateRangeFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.RelativeDateRangeFilter? RelativeDateRangeFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.RelativeDateRangeFilter RelativeDateRangeFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.StaticDateFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.StaticDateFilter? StaticDateFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.StaticDateFilter StaticDateFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.StaticDateRangeFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.StaticDateRangeFilter? StaticDateRangeFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.StaticDateRangeFilter StaticDateRangeFilter { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.BounceDateFilter.BounceDateFilter_filter"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.BounceDateFilter.BounceDateFilter_filter CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::ApiSdk.Models.BounceDateFilter.BounceDateFilter_filter();
                if("AnniversaryDateFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.AnniversaryDateFilter = new global::ApiSdk.Models.AnniversaryDateFilter();
                }
                else if("CalendarDateFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CalendarDateFilter = new global::ApiSdk.Models.CalendarDateFilter();
                }
                else if("IsSetExistenceFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.IsSetExistenceFilter = new global::ApiSdk.Models.IsSetExistenceFilter();
                }
                else if("RelativeAnniversaryDateFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.RelativeAnniversaryDateFilter = new global::ApiSdk.Models.RelativeAnniversaryDateFilter();
                }
                else if("RelativeDateOperatorBaseFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.RelativeDateOperatorBaseFilter = new global::ApiSdk.Models.RelativeDateOperatorBaseFilter();
                }
                else if("RelativeDateRangeFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.RelativeDateRangeFilter = new global::ApiSdk.Models.RelativeDateRangeFilter();
                }
                else if("StaticDateFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.StaticDateFilter = new global::ApiSdk.Models.StaticDateFilter();
                }
                else if("StaticDateRangeFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.StaticDateRangeFilter = new global::ApiSdk.Models.StaticDateRangeFilter();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(AnniversaryDateFilter != null)
                {
                    return AnniversaryDateFilter.GetFieldDeserializers();
                }
                else if(CalendarDateFilter != null)
                {
                    return CalendarDateFilter.GetFieldDeserializers();
                }
                else if(IsSetExistenceFilter != null)
                {
                    return IsSetExistenceFilter.GetFieldDeserializers();
                }
                else if(RelativeAnniversaryDateFilter != null)
                {
                    return RelativeAnniversaryDateFilter.GetFieldDeserializers();
                }
                else if(RelativeDateOperatorBaseFilter != null)
                {
                    return RelativeDateOperatorBaseFilter.GetFieldDeserializers();
                }
                else if(RelativeDateRangeFilter != null)
                {
                    return RelativeDateRangeFilter.GetFieldDeserializers();
                }
                else if(StaticDateFilter != null)
                {
                    return StaticDateFilter.GetFieldDeserializers();
                }
                else if(StaticDateRangeFilter != null)
                {
                    return StaticDateRangeFilter.GetFieldDeserializers();
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
                if(AnniversaryDateFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.AnniversaryDateFilter>(null, AnniversaryDateFilter);
                }
                else if(CalendarDateFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.CalendarDateFilter>(null, CalendarDateFilter);
                }
                else if(IsSetExistenceFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.IsSetExistenceFilter>(null, IsSetExistenceFilter);
                }
                else if(RelativeAnniversaryDateFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.RelativeAnniversaryDateFilter>(null, RelativeAnniversaryDateFilter);
                }
                else if(RelativeDateOperatorBaseFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.RelativeDateOperatorBaseFilter>(null, RelativeDateOperatorBaseFilter);
                }
                else if(RelativeDateRangeFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.RelativeDateRangeFilter>(null, RelativeDateRangeFilter);
                }
                else if(StaticDateFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.StaticDateFilter>(null, StaticDateFilter);
                }
                else if(StaticDateRangeFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.StaticDateRangeFilter>(null, StaticDateRangeFilter);
                }
            }
        }
    }
}
#pragma warning restore CS0618
