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
    public partial class EventResponseObjectResource_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Event timestamp in ISO8601 format (YYYY-MM-DDTHH:MM:SS+hh:mm)</summary>
        public DateTimeOffset? Datetime { get; set; }
        /// <summary>Event properties, can include identifiers and extra properties</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.EventResponseObjectResource_attributes_event_properties? EventProperties { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.EventResponseObjectResource_attributes_event_properties EventProperties { get; set; }
#endif
        /// <summary>Event timestamp in seconds</summary>
        public int? Timestamp { get; set; }
        /// <summary>A unique identifier for the event, this can be used as a cursor in pagination</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uuid { get; set; }
#nullable restore
#else
        public string Uuid { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.EventResponseObjectResource_attributes"/> and sets the default values.
        /// </summary>
        public EventResponseObjectResource_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.EventResponseObjectResource_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.EventResponseObjectResource_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.EventResponseObjectResource_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "datetime", n => { Datetime = n.GetDateTimeOffsetValue(); } },
                { "event_properties", n => { EventProperties = n.GetObjectValue<global::ApiSdk.Models.EventResponseObjectResource_attributes_event_properties>(global::ApiSdk.Models.EventResponseObjectResource_attributes_event_properties.CreateFromDiscriminatorValue); } },
                { "timestamp", n => { Timestamp = n.GetIntValue(); } },
                { "uuid", n => { Uuid = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("datetime", Datetime);
            writer.WriteObjectValue<global::ApiSdk.Models.EventResponseObjectResource_attributes_event_properties>("event_properties", EventProperties);
            writer.WriteIntValue("timestamp", Timestamp);
            writer.WriteStringValue("uuid", Uuid);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
