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
    public partial class NoSMSMarketingUnsubscribed : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The filters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.NoSMSMarketingUnsubscribed.NoSMSMarketingUnsubscribed_filters>? Filters { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.NoSMSMarketingUnsubscribed.NoSMSMarketingUnsubscribed_filters> Filters { get; set; }
#endif
        /// <summary>The subscription property</summary>
        public global::ApiSdk.Models.UnsubscribedEnum? Subscription { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.NoSMSMarketingUnsubscribed"/> and sets the default values.
        /// </summary>
        public NoSMSMarketingUnsubscribed()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.NoSMSMarketingUnsubscribed"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.NoSMSMarketingUnsubscribed CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.NoSMSMarketingUnsubscribed();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "filters", n => { Filters = n.GetCollectionOfObjectValues<global::ApiSdk.Models.NoSMSMarketingUnsubscribed.NoSMSMarketingUnsubscribed_filters>(global::ApiSdk.Models.NoSMSMarketingUnsubscribed.NoSMSMarketingUnsubscribed_filters.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.NoSMSMarketingUnsubscribed.NoSMSMarketingUnsubscribed_filters>("filters", Filters);
            writer.WriteEnumValue<global::ApiSdk.Models.UnsubscribedEnum>("subscription", Subscription);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.BulkRemoveMethodFilter"/>, <see cref="global::ApiSdk.Models.CarrierDeactivationMethodFilter"/>, <see cref="global::ApiSdk.Models.CheckoutMethodFilter"/>, <see cref="global::ApiSdk.Models.FailedAgeGateMethodFilter"/>, <see cref="global::ApiSdk.Models.FormMethodFilter"/>, <see cref="global::ApiSdk.Models.InboundMessageMethodFilter"/>, <see cref="global::ApiSdk.Models.ManualAddMethodFilter"/>, <see cref="global::ApiSdk.Models.ManualImportMethodFilter"/>, <see cref="global::ApiSdk.Models.ManualRemoveMethodFilter"/>, <see cref="global::ApiSdk.Models.MessageBlockedMethodFilter"/>, <see cref="global::ApiSdk.Models.PreferencePageMethodFilter"/>, <see cref="global::ApiSdk.Models.ProvidedLandlineMethodFilter"/>, <see cref="global::ApiSdk.Models.ProvidedNoAgeMethodFilter"/>, <see cref="global::ApiSdk.Models.SftpMethodFilter"/>, <see cref="global::ApiSdk.Models.ShopifyIntegrationMethodFilter"/>, <see cref="global::ApiSdk.Models.StatusDateFilter"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class NoSMSMarketingUnsubscribed_filters : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.BulkRemoveMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.BulkRemoveMethodFilter? BulkRemoveMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.BulkRemoveMethodFilter BulkRemoveMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CarrierDeactivationMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CarrierDeactivationMethodFilter? CarrierDeactivationMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CarrierDeactivationMethodFilter CarrierDeactivationMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CheckoutMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CheckoutMethodFilter? CheckoutMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CheckoutMethodFilter CheckoutMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.FailedAgeGateMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.FailedAgeGateMethodFilter? FailedAgeGateMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.FailedAgeGateMethodFilter FailedAgeGateMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.FormMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.FormMethodFilter? FormMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.FormMethodFilter FormMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.InboundMessageMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.InboundMessageMethodFilter? InboundMessageMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.InboundMessageMethodFilter InboundMessageMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.ManualAddMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.ManualAddMethodFilter? ManualAddMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.ManualAddMethodFilter ManualAddMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.ManualImportMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.ManualImportMethodFilter? ManualImportMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.ManualImportMethodFilter ManualImportMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.ManualRemoveMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.ManualRemoveMethodFilter? ManualRemoveMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.ManualRemoveMethodFilter ManualRemoveMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.MessageBlockedMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.MessageBlockedMethodFilter? MessageBlockedMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.MessageBlockedMethodFilter MessageBlockedMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.PreferencePageMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.PreferencePageMethodFilter? PreferencePageMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.PreferencePageMethodFilter PreferencePageMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.ProvidedLandlineMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.ProvidedLandlineMethodFilter? ProvidedLandlineMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.ProvidedLandlineMethodFilter ProvidedLandlineMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.ProvidedNoAgeMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.ProvidedNoAgeMethodFilter? ProvidedNoAgeMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.ProvidedNoAgeMethodFilter ProvidedNoAgeMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.SftpMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.SftpMethodFilter? SftpMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.SftpMethodFilter SftpMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.ShopifyIntegrationMethodFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.ShopifyIntegrationMethodFilter? ShopifyIntegrationMethodFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.ShopifyIntegrationMethodFilter ShopifyIntegrationMethodFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.StatusDateFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.StatusDateFilter? StatusDateFilter { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.StatusDateFilter StatusDateFilter { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.NoSMSMarketingUnsubscribed.NoSMSMarketingUnsubscribed_filters"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.NoSMSMarketingUnsubscribed.NoSMSMarketingUnsubscribed_filters CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::ApiSdk.Models.NoSMSMarketingUnsubscribed.NoSMSMarketingUnsubscribed_filters();
                if("BulkRemoveMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.BulkRemoveMethodFilter = new global::ApiSdk.Models.BulkRemoveMethodFilter();
                }
                else if("CarrierDeactivationMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CarrierDeactivationMethodFilter = new global::ApiSdk.Models.CarrierDeactivationMethodFilter();
                }
                else if("CheckoutMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CheckoutMethodFilter = new global::ApiSdk.Models.CheckoutMethodFilter();
                }
                else if("FailedAgeGateMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.FailedAgeGateMethodFilter = new global::ApiSdk.Models.FailedAgeGateMethodFilter();
                }
                else if("FormMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.FormMethodFilter = new global::ApiSdk.Models.FormMethodFilter();
                }
                else if("InboundMessageMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.InboundMessageMethodFilter = new global::ApiSdk.Models.InboundMessageMethodFilter();
                }
                else if("ManualAddMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ManualAddMethodFilter = new global::ApiSdk.Models.ManualAddMethodFilter();
                }
                else if("ManualImportMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ManualImportMethodFilter = new global::ApiSdk.Models.ManualImportMethodFilter();
                }
                else if("ManualRemoveMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ManualRemoveMethodFilter = new global::ApiSdk.Models.ManualRemoveMethodFilter();
                }
                else if("MessageBlockedMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.MessageBlockedMethodFilter = new global::ApiSdk.Models.MessageBlockedMethodFilter();
                }
                else if("PreferencePageMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.PreferencePageMethodFilter = new global::ApiSdk.Models.PreferencePageMethodFilter();
                }
                else if("ProvidedLandlineMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProvidedLandlineMethodFilter = new global::ApiSdk.Models.ProvidedLandlineMethodFilter();
                }
                else if("ProvidedNoAgeMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProvidedNoAgeMethodFilter = new global::ApiSdk.Models.ProvidedNoAgeMethodFilter();
                }
                else if("SftpMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SftpMethodFilter = new global::ApiSdk.Models.SftpMethodFilter();
                }
                else if("ShopifyIntegrationMethodFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ShopifyIntegrationMethodFilter = new global::ApiSdk.Models.ShopifyIntegrationMethodFilter();
                }
                else if("StatusDateFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.StatusDateFilter = new global::ApiSdk.Models.StatusDateFilter();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(BulkRemoveMethodFilter != null)
                {
                    return BulkRemoveMethodFilter.GetFieldDeserializers();
                }
                else if(CarrierDeactivationMethodFilter != null)
                {
                    return CarrierDeactivationMethodFilter.GetFieldDeserializers();
                }
                else if(CheckoutMethodFilter != null)
                {
                    return CheckoutMethodFilter.GetFieldDeserializers();
                }
                else if(FailedAgeGateMethodFilter != null)
                {
                    return FailedAgeGateMethodFilter.GetFieldDeserializers();
                }
                else if(FormMethodFilter != null)
                {
                    return FormMethodFilter.GetFieldDeserializers();
                }
                else if(InboundMessageMethodFilter != null)
                {
                    return InboundMessageMethodFilter.GetFieldDeserializers();
                }
                else if(ManualAddMethodFilter != null)
                {
                    return ManualAddMethodFilter.GetFieldDeserializers();
                }
                else if(ManualImportMethodFilter != null)
                {
                    return ManualImportMethodFilter.GetFieldDeserializers();
                }
                else if(ManualRemoveMethodFilter != null)
                {
                    return ManualRemoveMethodFilter.GetFieldDeserializers();
                }
                else if(MessageBlockedMethodFilter != null)
                {
                    return MessageBlockedMethodFilter.GetFieldDeserializers();
                }
                else if(PreferencePageMethodFilter != null)
                {
                    return PreferencePageMethodFilter.GetFieldDeserializers();
                }
                else if(ProvidedLandlineMethodFilter != null)
                {
                    return ProvidedLandlineMethodFilter.GetFieldDeserializers();
                }
                else if(ProvidedNoAgeMethodFilter != null)
                {
                    return ProvidedNoAgeMethodFilter.GetFieldDeserializers();
                }
                else if(SftpMethodFilter != null)
                {
                    return SftpMethodFilter.GetFieldDeserializers();
                }
                else if(ShopifyIntegrationMethodFilter != null)
                {
                    return ShopifyIntegrationMethodFilter.GetFieldDeserializers();
                }
                else if(StatusDateFilter != null)
                {
                    return StatusDateFilter.GetFieldDeserializers();
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
                if(BulkRemoveMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.BulkRemoveMethodFilter>(null, BulkRemoveMethodFilter);
                }
                else if(CarrierDeactivationMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.CarrierDeactivationMethodFilter>(null, CarrierDeactivationMethodFilter);
                }
                else if(CheckoutMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.CheckoutMethodFilter>(null, CheckoutMethodFilter);
                }
                else if(FailedAgeGateMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.FailedAgeGateMethodFilter>(null, FailedAgeGateMethodFilter);
                }
                else if(FormMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.FormMethodFilter>(null, FormMethodFilter);
                }
                else if(InboundMessageMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.InboundMessageMethodFilter>(null, InboundMessageMethodFilter);
                }
                else if(ManualAddMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.ManualAddMethodFilter>(null, ManualAddMethodFilter);
                }
                else if(ManualImportMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.ManualImportMethodFilter>(null, ManualImportMethodFilter);
                }
                else if(ManualRemoveMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.ManualRemoveMethodFilter>(null, ManualRemoveMethodFilter);
                }
                else if(MessageBlockedMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.MessageBlockedMethodFilter>(null, MessageBlockedMethodFilter);
                }
                else if(PreferencePageMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.PreferencePageMethodFilter>(null, PreferencePageMethodFilter);
                }
                else if(ProvidedLandlineMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.ProvidedLandlineMethodFilter>(null, ProvidedLandlineMethodFilter);
                }
                else if(ProvidedNoAgeMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.ProvidedNoAgeMethodFilter>(null, ProvidedNoAgeMethodFilter);
                }
                else if(SftpMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.SftpMethodFilter>(null, SftpMethodFilter);
                }
                else if(ShopifyIntegrationMethodFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.ShopifyIntegrationMethodFilter>(null, ShopifyIntegrationMethodFilter);
                }
                else if(StatusDateFilter != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.StatusDateFilter>(null, StatusDateFilter);
                }
            }
        }
    }
}
#pragma warning restore CS0618
