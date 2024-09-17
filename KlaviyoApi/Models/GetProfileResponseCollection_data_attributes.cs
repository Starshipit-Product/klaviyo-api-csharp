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
    public partial class GetProfileResponseCollection_data_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the profile was created, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)</summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary>Individual&apos;s email address</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>A unique identifier used by customers to associate Klaviyo profiles with profiles in an external system, such as a point-of-sale system. Format varies based on the external system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>Individual&apos;s first name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>URL pointing to the location of a profile image</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Image { get; set; }
#nullable restore
#else
        public string Image { get; set; }
#endif
        /// <summary>Date and time of the most recent event the triggered an update to the profile, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)</summary>
        public DateTimeOffset? LastEventDate { get; set; }
        /// <summary>Individual&apos;s last name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>The locale of the profile, in the IETF BCP 47 language tag format (language-extlang-script-region-variant-extension-privateuse)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locale { get; set; }
#nullable restore
#else
        public string Locale { get; set; }
#endif
        /// <summary>The location property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ProfileLocation? Location { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ProfileLocation Location { get; set; }
#endif
        /// <summary>Name of the company or organization within the company for whom the individual works</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Organization { get; set; }
#nullable restore
#else
        public string Organization { get; set; }
#endif
        /// <summary>Individual&apos;s phone number in E.164 format</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>An object containing key/value pairs for any custom properties assigned to this profile</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.GetProfileResponseCollection_data_attributes_properties? Properties { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.GetProfileResponseCollection_data_attributes_properties Properties { get; set; }
#endif
        /// <summary>Individual&apos;s job title</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>Date and time when the profile was last updated, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)</summary>
        public DateTimeOffset? Updated { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.GetProfileResponseCollection_data_attributes"/> and sets the default values.
        /// </summary>
        public GetProfileResponseCollection_data_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GetProfileResponseCollection_data_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.GetProfileResponseCollection_data_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.GetProfileResponseCollection_data_attributes();
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
                { "email", n => { Email = n.GetStringValue(); } },
                { "external_id", n => { ExternalId = n.GetStringValue(); } },
                { "first_name", n => { FirstName = n.GetStringValue(); } },
                { "image", n => { Image = n.GetStringValue(); } },
                { "last_event_date", n => { LastEventDate = n.GetDateTimeOffsetValue(); } },
                { "last_name", n => { LastName = n.GetStringValue(); } },
                { "locale", n => { Locale = n.GetStringValue(); } },
                { "location", n => { Location = n.GetObjectValue<global::ApiSdk.Models.ProfileLocation>(global::ApiSdk.Models.ProfileLocation.CreateFromDiscriminatorValue); } },
                { "organization", n => { Organization = n.GetStringValue(); } },
                { "phone_number", n => { PhoneNumber = n.GetStringValue(); } },
                { "properties", n => { Properties = n.GetObjectValue<global::ApiSdk.Models.GetProfileResponseCollection_data_attributes_properties>(global::ApiSdk.Models.GetProfileResponseCollection_data_attributes_properties.CreateFromDiscriminatorValue); } },
                { "title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("external_id", ExternalId);
            writer.WriteStringValue("first_name", FirstName);
            writer.WriteStringValue("image", Image);
            writer.WriteDateTimeOffsetValue("last_event_date", LastEventDate);
            writer.WriteStringValue("last_name", LastName);
            writer.WriteStringValue("locale", Locale);
            writer.WriteObjectValue<global::ApiSdk.Models.ProfileLocation>("location", Location);
            writer.WriteStringValue("organization", Organization);
            writer.WriteStringValue("phone_number", PhoneNumber);
            writer.WriteObjectValue<global::ApiSdk.Models.GetProfileResponseCollection_data_attributes_properties>("properties", Properties);
            writer.WriteStringValue("title", Title);
            writer.WriteDateTimeOffsetValue("updated", Updated);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
