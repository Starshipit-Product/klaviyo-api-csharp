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
    public partial class PushTokenUnregisterQueryResourceObject_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The platform on which the push token was created.</summary>
        public global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes_platform? Platform { get; set; }
        /// <summary>The profile associated with the push token to create/update</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes_profile? Profile { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes_profile Profile { get; set; }
#endif
        /// <summary>A push token from APNS or FCM.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The vendor of the push token.</summary>
        public global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes_vendor? Vendor { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes"/> and sets the default values.
        /// </summary>
        public PushTokenUnregisterQueryResourceObject_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "platform", n => { Platform = n.GetEnumValue<global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes_platform>(); } },
                { "profile", n => { Profile = n.GetObjectValue<global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes_profile>(global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes_profile.CreateFromDiscriminatorValue); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "vendor", n => { Vendor = n.GetEnumValue<global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes_vendor>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes_platform>("platform", Platform);
            writer.WriteObjectValue<global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes_profile>("profile", Profile);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<global::ApiSdk.Models.PushTokenUnregisterQueryResourceObject_attributes_vendor>("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
