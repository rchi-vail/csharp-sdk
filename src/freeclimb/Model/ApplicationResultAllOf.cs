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
    /// ApplicationResultAllOf
    /// </summary>
    [DataContract(Name = "ApplicationResult_allOf")]
    public partial class ApplicationResultAllOf : IEquatable<ApplicationResultAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationResultAllOf" /> class.
        /// </summary>
        /// <param name="accountId">ID of the account that owns this phone number..</param>
        /// <param name="applicationId">ID of the Application that FreeClimb should contact if a Call or SMS arrives for this phone number or a Call from this number is placed. An incoming phone number is not useful until associated with an applicationId..</param>
        /// <param name="alias">Description for this phone number. Typically the conventionally-formatted version of the phone number..</param>
        /// <param name="voiceUrl">The URL FreeClimb will request when a phone number assigned to this Application receives a Call. Used for inbound calls only..</param>
        /// <param name="voiceFallbackUrl">The URL that FreeClimb will request if it times out waiting for a response from the voiceUrl. Used for inbound calls only..</param>
        /// <param name="callConnectUrl">The URL to which FreeClimb will make a POST request informing the result of the outbound Call request. The status property of the request message specifies if the Call was connected or not..</param>
        /// <param name="statusCallbackUrl">A URL to which FreeClimb will make a POST request when the Call ends to notify this app..</param>
        /// <param name="smsUrl">The URL FreeClimb will request when a phone number assigned to this Application receives an incoming SMS message. Used for inbound SMS only..</param>
        /// <param name="smsFallbackUrl">The URL that FreeClimb will request if it times out waiting for a response from the smsUrl. Used for inbound SMS only..</param>
        public ApplicationResultAllOf(string accountId = default(string), string applicationId = default(string), string alias = default(string), string voiceUrl = default(string), string voiceFallbackUrl = default(string), string callConnectUrl = default(string), string statusCallbackUrl = default(string), string smsUrl = default(string), string smsFallbackUrl = default(string))
        {
            this.AccountId = accountId;
            this.ApplicationId = applicationId;
            this.Alias = alias;
            this.VoiceUrl = voiceUrl;
            this.VoiceFallbackUrl = voiceFallbackUrl;
            this.CallConnectUrl = callConnectUrl;
            this.StatusCallbackUrl = statusCallbackUrl;
            this.SmsUrl = smsUrl;
            this.SmsFallbackUrl = smsFallbackUrl;
        }

        /// <summary>
        /// ID of the account that owns this phone number.
        /// </summary>
        /// <value>ID of the account that owns this phone number.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// ID of the Application that FreeClimb should contact if a Call or SMS arrives for this phone number or a Call from this number is placed. An incoming phone number is not useful until associated with an applicationId.
        /// </summary>
        /// <value>ID of the Application that FreeClimb should contact if a Call or SMS arrives for this phone number or a Call from this number is placed. An incoming phone number is not useful until associated with an applicationId.</value>
        [DataMember(Name = "applicationId", EmitDefaultValue = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Description for this phone number. Typically the conventionally-formatted version of the phone number.
        /// </summary>
        /// <value>Description for this phone number. Typically the conventionally-formatted version of the phone number.</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// The URL FreeClimb will request when a phone number assigned to this Application receives a Call. Used for inbound calls only.
        /// </summary>
        /// <value>The URL FreeClimb will request when a phone number assigned to this Application receives a Call. Used for inbound calls only.</value>
        [DataMember(Name = "voiceUrl", EmitDefaultValue = true)]
        public string VoiceUrl { get; set; }

        /// <summary>
        /// The URL that FreeClimb will request if it times out waiting for a response from the voiceUrl. Used for inbound calls only.
        /// </summary>
        /// <value>The URL that FreeClimb will request if it times out waiting for a response from the voiceUrl. Used for inbound calls only.</value>
        [DataMember(Name = "voiceFallbackUrl", EmitDefaultValue = true)]
        public string VoiceFallbackUrl { get; set; }

        /// <summary>
        /// The URL to which FreeClimb will make a POST request informing the result of the outbound Call request. The status property of the request message specifies if the Call was connected or not.
        /// </summary>
        /// <value>The URL to which FreeClimb will make a POST request informing the result of the outbound Call request. The status property of the request message specifies if the Call was connected or not.</value>
        [DataMember(Name = "callConnectUrl", EmitDefaultValue = true)]
        public string CallConnectUrl { get; set; }

        /// <summary>
        /// A URL to which FreeClimb will make a POST request when the Call ends to notify this app.
        /// </summary>
        /// <value>A URL to which FreeClimb will make a POST request when the Call ends to notify this app.</value>
        [DataMember(Name = "statusCallbackUrl", EmitDefaultValue = true)]
        public string StatusCallbackUrl { get; set; }

        /// <summary>
        /// The URL FreeClimb will request when a phone number assigned to this Application receives an incoming SMS message. Used for inbound SMS only.
        /// </summary>
        /// <value>The URL FreeClimb will request when a phone number assigned to this Application receives an incoming SMS message. Used for inbound SMS only.</value>
        [DataMember(Name = "smsUrl", EmitDefaultValue = true)]
        public string SmsUrl { get; set; }

        /// <summary>
        /// The URL that FreeClimb will request if it times out waiting for a response from the smsUrl. Used for inbound SMS only.
        /// </summary>
        /// <value>The URL that FreeClimb will request if it times out waiting for a response from the smsUrl. Used for inbound SMS only.</value>
        [DataMember(Name = "smsFallbackUrl", EmitDefaultValue = true)]
        public string SmsFallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationResultAllOf {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  VoiceUrl: ").Append(VoiceUrl).Append("\n");
            sb.Append("  VoiceFallbackUrl: ").Append(VoiceFallbackUrl).Append("\n");
            sb.Append("  CallConnectUrl: ").Append(CallConnectUrl).Append("\n");
            sb.Append("  StatusCallbackUrl: ").Append(StatusCallbackUrl).Append("\n");
            sb.Append("  SmsUrl: ").Append(SmsUrl).Append("\n");
            sb.Append("  SmsFallbackUrl: ").Append(SmsFallbackUrl).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationResultAllOf);
        }

        /// <summary>
        /// Returns true if ApplicationResultAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationResultAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationResultAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.VoiceUrl == input.VoiceUrl ||
                    (this.VoiceUrl != null &&
                    this.VoiceUrl.Equals(input.VoiceUrl))
                ) && 
                (
                    this.VoiceFallbackUrl == input.VoiceFallbackUrl ||
                    (this.VoiceFallbackUrl != null &&
                    this.VoiceFallbackUrl.Equals(input.VoiceFallbackUrl))
                ) && 
                (
                    this.CallConnectUrl == input.CallConnectUrl ||
                    (this.CallConnectUrl != null &&
                    this.CallConnectUrl.Equals(input.CallConnectUrl))
                ) && 
                (
                    this.StatusCallbackUrl == input.StatusCallbackUrl ||
                    (this.StatusCallbackUrl != null &&
                    this.StatusCallbackUrl.Equals(input.StatusCallbackUrl))
                ) && 
                (
                    this.SmsUrl == input.SmsUrl ||
                    (this.SmsUrl != null &&
                    this.SmsUrl.Equals(input.SmsUrl))
                ) && 
                (
                    this.SmsFallbackUrl == input.SmsFallbackUrl ||
                    (this.SmsFallbackUrl != null &&
                    this.SmsFallbackUrl.Equals(input.SmsFallbackUrl))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                if (this.Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                }
                if (this.VoiceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.VoiceUrl.GetHashCode();
                }
                if (this.VoiceFallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.VoiceFallbackUrl.GetHashCode();
                }
                if (this.CallConnectUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallConnectUrl.GetHashCode();
                }
                if (this.StatusCallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.StatusCallbackUrl.GetHashCode();
                }
                if (this.SmsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SmsUrl.GetHashCode();
                }
                if (this.SmsFallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SmsFallbackUrl.GetHashCode();
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
