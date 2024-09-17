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
    public partial class NoEmailMarketingUnsubscribed : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The filters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.NoEmailMarketingUnsubscribed.NoEmailMarketingUnsubscribed_filters? Filters { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.NoEmailMarketingUnsubscribed.NoEmailMarketingUnsubscribed_filters Filters { get; set; }
#endif
        /// <summary>The subscription property</summary>
        public global::ApiSdk.Models.UnsubscribedEnum? Subscription { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.NoEmailMarketingUnsubscribed"/> and sets the default values.
        /// </summary>
        public NoEmailMarketingUnsubscribed()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.NoEmailMarketingUnsubscribed"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.NoEmailMarketingUnsubscribed CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.NoEmailMarketingUnsubscribed();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "filters", n => { Filters = n.GetObjectValue<global::ApiSdk.Models.NoEmailMarketingUnsubscribed.NoEmailMarketingUnsubscribed_filters>(global::ApiSdk.Models.NoEmailMarketingUnsubscribed.NoEmailMarketingUnsubscribed_filters.CreateFromDiscriminatorValue); } },
                { "subscription", n => { Subscription = n.GetEnumValue<global::ApiSdk.Models.UnsubscribedEnum>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.NoEmailMarketingUnsubscribed.NoEmailMarketingUnsubscribed_filters>("filters", Filters);
            writer.WriteEnumValue<global::ApiSdk.Models.UnsubscribedEnum>("subscription", Subscription);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes List&lt;global::ApiSdk.Models.ConstantContactIntegrationMethodFilter&gt;, List&lt;global::ApiSdk.Models.InvalidEmailDateFilter&gt;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class NoEmailMarketingUnsubscribed_filters : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type List&lt;global::ApiSdk.Models.ConstantContactIntegrationMethodFilter&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<global::ApiSdk.Models.ConstantContactIntegrationMethodFilter>? ConstantContactIntegrationMethodFilter { get; set; }
#nullable restore
#else
            public List<global::ApiSdk.Models.ConstantContactIntegrationMethodFilter> ConstantContactIntegrationMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;global::ApiSdk.Models.InvalidEmailDateFilter&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<global::ApiSdk.Models.InvalidEmailDateFilter>? InvalidEmailDateFilter { get; set; }
#nullable restore
#else
            public List<global::ApiSdk.Models.InvalidEmailDateFilter> InvalidEmailDateFilter { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.NoEmailMarketingUnsubscribed.NoEmailMarketingUnsubscribed_filters"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.NoEmailMarketingUnsubscribed.NoEmailMarketingUnsubscribed_filters CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::ApiSdk.Models.NoEmailMarketingUnsubscribed.NoEmailMarketingUnsubscribed_filters();
                if(parseNode.GetCollectionOfObjectValues<global::ApiSdk.Models.ConstantContactIntegrationMethodFilter>(global::ApiSdk.Models.ConstantContactIntegrationMethodFilter.CreateFromDiscriminatorValue)?.AsList() is List<global::ApiSdk.Models.ConstantContactIntegrationMethodFilter> constantContactIntegrationMethodFilterValue)
                {
                    result.ConstantContactIntegrationMethodFilter = constantContactIntegrationMethodFilterValue;
                }
                else if(parseNode.GetCollectionOfObjectValues<global::ApiSdk.Models.InvalidEmailDateFilter>(global::ApiSdk.Models.InvalidEmailDateFilter.CreateFromDiscriminatorValue)?.AsList() is List<global::ApiSdk.Models.InvalidEmailDateFilter> invalidEmailDateFilterValue)
                {
                    result.InvalidEmailDateFilter = invalidEmailDateFilterValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(ConstantContactIntegrationMethodFilter != null)
                {
                    writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ConstantContactIntegrationMethodFilter>(null, ConstantContactIntegrationMethodFilter);
                }
                else if(InvalidEmailDateFilter != null)
                {
                    writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.InvalidEmailDateFilter>(null, InvalidEmailDateFilter);
                }
            }
        }
    }
}
#pragma warning restore CS0618
