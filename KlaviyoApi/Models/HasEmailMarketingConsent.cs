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
    public partial class HasEmailMarketingConsent : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The can_receive_marketing property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? CanReceiveMarketing { get; set; }
#nullable restore
#else
        public UntypedNode CanReceiveMarketing { get; set; }
#endif
        /// <summary>The channel property</summary>
        public global::ApiSdk.Models.EmailEnum? Channel { get; set; }
        /// <summary>The consent_status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.HasEmailMarketingConsent.HasEmailMarketingConsent_consent_status? ConsentStatus { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.HasEmailMarketingConsent.HasEmailMarketingConsent_consent_status ConsentStatus { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.HasEmailMarketingConsent"/> and sets the default values.
        /// </summary>
        public HasEmailMarketingConsent()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.HasEmailMarketingConsent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.HasEmailMarketingConsent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.HasEmailMarketingConsent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "can_receive_marketing", n => { CanReceiveMarketing = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "channel", n => { Channel = n.GetEnumValue<global::ApiSdk.Models.EmailEnum>(); } },
                { "consent_status", n => { ConsentStatus = n.GetObjectValue<global::ApiSdk.Models.HasEmailMarketingConsent.HasEmailMarketingConsent_consent_status>(global::ApiSdk.Models.HasEmailMarketingConsent.HasEmailMarketingConsent_consent_status.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("can_receive_marketing", CanReceiveMarketing);
            writer.WriteEnumValue<global::ApiSdk.Models.EmailEnum>("channel", Channel);
            writer.WriteObjectValue<global::ApiSdk.Models.HasEmailMarketingConsent.HasEmailMarketingConsent_consent_status>("consent_status", ConsentStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.HasEmailMarketing"/>, <see cref="global::ApiSdk.Models.HasEmailMarketingNeverSubscribed"/>, <see cref="global::ApiSdk.Models.HasEmailMarketingSubscribed"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class HasEmailMarketingConsent_consent_status : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.HasEmailMarketing"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.HasEmailMarketing? HasEmailMarketing { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.HasEmailMarketing HasEmailMarketing { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.HasEmailMarketingNeverSubscribed"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.HasEmailMarketingNeverSubscribed? HasEmailMarketingNeverSubscribed { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.HasEmailMarketingNeverSubscribed HasEmailMarketingNeverSubscribed { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.HasEmailMarketingSubscribed"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.HasEmailMarketingSubscribed? HasEmailMarketingSubscribed { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.HasEmailMarketingSubscribed HasEmailMarketingSubscribed { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.HasEmailMarketingConsent.HasEmailMarketingConsent_consent_status"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.HasEmailMarketingConsent.HasEmailMarketingConsent_consent_status CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::ApiSdk.Models.HasEmailMarketingConsent.HasEmailMarketingConsent_consent_status();
                if("HasEmailMarketing".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.HasEmailMarketing = new global::ApiSdk.Models.HasEmailMarketing();
                }
                else if("HasEmailMarketingNeverSubscribed".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.HasEmailMarketingNeverSubscribed = new global::ApiSdk.Models.HasEmailMarketingNeverSubscribed();
                }
                else if("HasEmailMarketingSubscribed".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.HasEmailMarketingSubscribed = new global::ApiSdk.Models.HasEmailMarketingSubscribed();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(HasEmailMarketing != null)
                {
                    return HasEmailMarketing.GetFieldDeserializers();
                }
                else if(HasEmailMarketingNeverSubscribed != null)
                {
                    return HasEmailMarketingNeverSubscribed.GetFieldDeserializers();
                }
                else if(HasEmailMarketingSubscribed != null)
                {
                    return HasEmailMarketingSubscribed.GetFieldDeserializers();
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
                if(HasEmailMarketing != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.HasEmailMarketing>(null, HasEmailMarketing);
                }
                else if(HasEmailMarketingNeverSubscribed != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.HasEmailMarketingNeverSubscribed>(null, HasEmailMarketingNeverSubscribed);
                }
                else if(HasEmailMarketingSubscribed != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.HasEmailMarketingSubscribed>(null, HasEmailMarketingSubscribed);
                }
            }
        }
    }
}
#pragma warning restore CS0618
