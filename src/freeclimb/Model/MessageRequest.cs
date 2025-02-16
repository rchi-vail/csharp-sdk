/*
 * FreeClimb API
 *
 * FreeClimb is a cloud-based application programming interface (API) that puts the power of the Vail platform in your hands. FreeClimb simplifies the process of creating applications that can use a full range of telephony features without requiring specialized or on-site telephony equipment. Using the FreeClimb REST API to write applications is easy! You have the option to use the language of your choice or hit the API directly. Your application can execute a command by issuing a RESTful request to the FreeClimb API. The base URL to send HTTP requests to the FreeClimb REST API is: /apiserver. FreeClimb authenticates and processes your request.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@freeclimb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;

namespace freeclimb.Model
{
    /// <summary>
    /// MessageRequest
    /// </summary>
    [DataContract(Name = "MessageRequest")]
    public partial class MessageRequest : IEquatable<MessageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequest" /> class.
        /// </summary>
        /// <param name="uri">The URI for this resource, relative to /apiserver..</param>
        /// <param name="dateCreated">The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT)..</param>
        /// <param name="dateUpdated">The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT)..</param>
        /// <param name="revision">Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated..</param>
        /// <param name="from">Phone number to use as the sender. This must be an incoming phone number that you have purchased from FreeClimb. (required).</param>
        /// <param name="to">Phone number to receive the message. Must be within FreeClimb&#39;s service area. (required).</param>
        /// <param name="text">Text contained in the message (maximum 160 characters).   **Note:** For text, only ASCII characters are supported. (required).</param>
        /// <param name="notificationUrl">When the Message changes status, this URL is invoked using HTTP POST with the messageStatus parameters.  **Note:** This is a notification only; any PerCL returned is ignored..</param>
        /// <param name="accountId">String that uniquely identifies this account resource..</param>
        public MessageRequest(string uri = default(string), string dateCreated = default(string), string dateUpdated = default(string), int revision = default(int), string from = default(string), string to = default(string), string text = default(string), string notificationUrl = default(string), string accountId = default(string))
        {
            // to ensure "from" is required (not null)
            if (from == null) {
                throw new ArgumentNullException("from is a required property for MessageRequest and cannot be null");
            }
            this.From = from;
            // to ensure "to" is required (not null)
            if (to == null) {
                throw new ArgumentNullException("to is a required property for MessageRequest and cannot be null");
            }
            this.To = to;
            // to ensure "text" is required (not null)
            if (text == null) {
                throw new ArgumentNullException("text is a required property for MessageRequest and cannot be null");
            }
            this.Text = text;
            this.Uri = uri;
            this.DateCreated = dateCreated;
            this.DateUpdated = dateUpdated;
            this.Revision = revision;
            this.NotificationUrl = notificationUrl;
            this.AccountId = accountId;
        }

        /// <summary>
        /// The URI for this resource, relative to /apiserver.
        /// </summary>
        /// <value>The URI for this resource, relative to /apiserver.</value>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT).
        /// </summary>
        /// <value>The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT).</value>
        [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
        public string DateCreated { get; set; }

        /// <summary>
        /// The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT).
        /// </summary>
        /// <value>The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT).</value>
        [DataMember(Name = "dateUpdated", EmitDefaultValue = false)]
        public string DateUpdated { get; set; }

        /// <summary>
        /// Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated.
        /// </summary>
        /// <value>Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated.</value>
        [DataMember(Name = "revision", EmitDefaultValue = false)]
        public int Revision { get; set; }

        /// <summary>
        /// Phone number to use as the sender. This must be an incoming phone number that you have purchased from FreeClimb.
        /// </summary>
        /// <value>Phone number to use as the sender. This must be an incoming phone number that you have purchased from FreeClimb.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Phone number to receive the message. Must be within FreeClimb&#39;s service area.
        /// </summary>
        /// <value>Phone number to receive the message. Must be within FreeClimb&#39;s service area.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Text contained in the message (maximum 160 characters).   **Note:** For text, only ASCII characters are supported.
        /// </summary>
        /// <value>Text contained in the message (maximum 160 characters).   **Note:** For text, only ASCII characters are supported.</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// When the Message changes status, this URL is invoked using HTTP POST with the messageStatus parameters.  **Note:** This is a notification only; any PerCL returned is ignored.
        /// </summary>
        /// <value>When the Message changes status, this URL is invoked using HTTP POST with the messageStatus parameters.  **Note:** This is a notification only; any PerCL returned is ignored.</value>
        [DataMember(Name = "notificationUrl", EmitDefaultValue = false)]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// String that uniquely identifies this account resource.
        /// </summary>
        /// <value>String that uniquely identifies this account resource.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageRequest {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  NotificationUrl: ").Append(NotificationUrl).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the MessageRequest instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("uri", Uri);          
            props.Add("dateCreated", DateCreated);          
            props.Add("dateUpdated", DateUpdated);          
            props.Add("revision", Revision);          
            props.Add("from", From);          
            props.Add("to", To);          
            props.Add("text", Text);          
            props.Add("notificationUrl", NotificationUrl);          
            props.Add("accountId", AccountId);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MessageRequest);
        }

        /// <summary>
        /// Returns true if MessageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.DateUpdated == input.DateUpdated ||
                    (this.DateUpdated != null &&
                    this.DateUpdated.Equals(input.DateUpdated))
                ) && 
                (
                    this.Revision == input.Revision ||
                    this.Revision.Equals(input.Revision)
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.NotificationUrl == input.NotificationUrl ||
                    (this.NotificationUrl != null &&
                    this.NotificationUrl.Equals(input.NotificationUrl))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Uri != null)
                {
                    hashCode = (hashCode * 59) + this.Uri.GetHashCode();
                }
                if (this.DateCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
                }
                if (this.DateUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.DateUpdated.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Revision.GetHashCode();
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.NotificationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationUrl.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
