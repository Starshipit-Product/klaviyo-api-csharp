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
    public partial class EmailMarketing : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether or not this profile has implicit consent to receive email marketing. True if it does profile does not have any global suppressions.</summary>
        public bool? CanReceiveEmailMarketing { get; set; }
        /// <summary>The consent status for email marketing.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Consent { get; set; }
#nullable restore
#else
        public string Consent { get; set; }
#endif
        /// <summary>The timestamp when consent was recorded or updated for email marketing, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).</summary>
        public DateTimeOffset? ConsentTimestamp { get; set; }
        /// <summary>Additional detail provided by the caller when the profile was subscribed. This may be empty if no details were provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomMethodDetail { get; set; }
#nullable restore
#else
        public string CustomMethodDetail { get; set; }
#endif
        /// <summary>Whether the profile was subscribed to email marketing using a double opt-in.</summary>
        public bool? DoubleOptin { get; set; }
        /// <summary>The timestamp when a field on the email marketing object was last modified.</summary>
        public DateTimeOffset? LastUpdated { get; set; }
        /// <summary>The list suppressions for this profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.EmailMarketingListSuppression>? ListSuppressions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.EmailMarketingListSuppression> ListSuppressions { get; set; }
#endif
        /// <summary>The method by which the profile was subscribed to email marketing.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Method { get; set; }
#nullable restore
#else
        public string Method { get; set; }
#endif
        /// <summary>Additional details about the method by which the profile was subscribed to email marketing. This may be empty if no details were provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MethodDetail { get; set; }
#nullable restore
#else
        public string MethodDetail { get; set; }
#endif
        /// <summary>The global email marketing suppression for this profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.EmailMarketingSuppression>? Suppression { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.EmailMarketingSuppression> Suppression { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.EmailMarketing"/> and sets the default values.
        /// </summary>
        public EmailMarketing()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.EmailMarketing"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.EmailMarketing CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.EmailMarketing();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "can_receive_email_marketing", n => { CanReceiveEmailMarketing = n.GetBoolValue(); } },
                { "consent", n => { Consent = n.GetStringValue(); } },
                { "consent_timestamp", n => { ConsentTimestamp = n.GetDateTimeOffsetValue(); } },
                { "custom_method_detail", n => { CustomMethodDetail = n.GetStringValue(); } },
                { "double_optin", n => { DoubleOptin = n.GetBoolValue(); } },
                { "last_updated", n => { LastUpdated = n.GetDateTimeOffsetValue(); } },
                { "list_suppressions", n => { ListSuppressions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.EmailMarketingListSuppression>(global::ApiSdk.Models.EmailMarketingListSuppression.CreateFromDiscriminatorValue)?.AsList(); } },
                { "method", n => { Method = n.GetStringValue(); } },
                { "method_detail", n => { MethodDetail = n.GetStringValue(); } },
                { "suppression", n => { Suppression = n.GetCollectionOfObjectValues<global::ApiSdk.Models.EmailMarketingSuppression>(global::ApiSdk.Models.EmailMarketingSuppression.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("can_receive_email_marketing", CanReceiveEmailMarketing);
            writer.WriteStringValue("consent", Consent);
            writer.WriteDateTimeOffsetValue("consent_timestamp", ConsentTimestamp);
            writer.WriteStringValue("custom_method_detail", CustomMethodDetail);
            writer.WriteBoolValue("double_optin", DoubleOptin);
            writer.WriteDateTimeOffsetValue("last_updated", LastUpdated);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.EmailMarketingListSuppression>("list_suppressions", ListSuppressions);
            writer.WriteStringValue("method", Method);
            writer.WriteStringValue("method_detail", MethodDetail);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.EmailMarketingSuppression>("suppression", Suppression);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
