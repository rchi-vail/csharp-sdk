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
    /// IncomingNumberResultAllOf
    /// </summary>
    [DataContract(Name = "IncomingNumberResult_allOf")]
    public partial class IncomingNumberResultAllOf : IEquatable<IncomingNumberResultAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomingNumberResultAllOf" /> class.
        /// </summary>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="campaignId">The campaign ID generated by the campaign registry.</param>
        /// <param name="phoneNumberId">String that uniquely identifies this phone number resource..</param>
        /// <param name="accountId">ID of the account that owns this phone number..</param>
        /// <param name="applicationId">ID of the Application that FreeClimb should contact if a Call or SMS arrives for this phone number or a Call from this number is placed. An incoming phone number is not useful until associated with an applicationId..</param>
        /// <param name="phoneNumber">Phone number in E.164 format..</param>
        /// <param name="alias">Description for this phone number. Typically the conventionally-formatted version of the phone number..</param>
        /// <param name="region">State or province of this phone number..</param>
        /// <param name="country">Country of this phone number..</param>
        /// <param name="voiceEnabled">Indicates whether the phone number can handle Calls. Typically set to true for all numbers..</param>
        /// <param name="smsEnabled">Indication of whether the phone number can handle sending and receiving SMS messages. Typically set to true for all numbers..</param>
        /// <param name="offnet">The offnet field is a boolean representing whether the number is offnet registered or not. This field will be rendered only for requests to the IncomingPhone number resource..</param>
        public IncomingNumberResultAllOf(Capabilities capabilities = default(Capabilities), string campaignId = default(string), string phoneNumberId = default(string), string accountId = default(string), string applicationId = default(string), string phoneNumber = default(string), string alias = default(string), string region = default(string), string country = default(string), bool? voiceEnabled = default(bool?), bool? smsEnabled = default(bool?), bool? offnet = default(bool?))
        {
            this.Capabilities = capabilities;
            this.CampaignId = campaignId;
            this.PhoneNumberId = phoneNumberId;
            this.AccountId = accountId;
            this.ApplicationId = applicationId;
            this.PhoneNumber = phoneNumber;
            this.Alias = alias;
            this.Region = region;
            this.Country = country;
            this.VoiceEnabled = voiceEnabled;
            this.SmsEnabled = smsEnabled;
            this.Offnet = offnet;
        }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public Capabilities Capabilities { get; set; }

        /// <summary>
        /// The campaign ID generated by the campaign registry
        /// </summary>
        /// <value>The campaign ID generated by the campaign registry</value>
        [DataMember(Name = "campaignId", EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// String that uniquely identifies this phone number resource.
        /// </summary>
        /// <value>String that uniquely identifies this phone number resource.</value>
        [DataMember(Name = "phoneNumberId", EmitDefaultValue = true)]
        public string PhoneNumberId { get; set; }

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
        /// Phone number in E.164 format.
        /// </summary>
        /// <value>Phone number in E.164 format.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Description for this phone number. Typically the conventionally-formatted version of the phone number.
        /// </summary>
        /// <value>Description for this phone number. Typically the conventionally-formatted version of the phone number.</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// State or province of this phone number.
        /// </summary>
        /// <value>State or province of this phone number.</value>
        [DataMember(Name = "region", EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// Country of this phone number.
        /// </summary>
        /// <value>Country of this phone number.</value>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Indicates whether the phone number can handle Calls. Typically set to true for all numbers.
        /// </summary>
        /// <value>Indicates whether the phone number can handle Calls. Typically set to true for all numbers.</value>
        [DataMember(Name = "voiceEnabled", EmitDefaultValue = true)]
        [Obsolete]
        public bool? VoiceEnabled { get; set; }

        /// <summary>
        /// Indication of whether the phone number can handle sending and receiving SMS messages. Typically set to true for all numbers.
        /// </summary>
        /// <value>Indication of whether the phone number can handle sending and receiving SMS messages. Typically set to true for all numbers.</value>
        [DataMember(Name = "smsEnabled", EmitDefaultValue = true)]
        [Obsolete]
        public bool? SmsEnabled { get; set; }

        /// <summary>
        /// The offnet field is a boolean representing whether the number is offnet registered or not. This field will be rendered only for requests to the IncomingPhone number resource.
        /// </summary>
        /// <value>The offnet field is a boolean representing whether the number is offnet registered or not. This field will be rendered only for requests to the IncomingPhone number resource.</value>
        [DataMember(Name = "offnet", EmitDefaultValue = true)]
        public bool? Offnet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IncomingNumberResultAllOf {\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  PhoneNumberId: ").Append(PhoneNumberId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  VoiceEnabled: ").Append(VoiceEnabled).Append("\n");
            sb.Append("  SmsEnabled: ").Append(SmsEnabled).Append("\n");
            sb.Append("  Offnet: ").Append(Offnet).Append("\n");
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
        /// Retrieve the KVP Dictionary for the IncomingNumberResultAllOf instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("capabilities", Capabilities);          
            props.Add("campaignId", CampaignId);          
            props.Add("phoneNumberId", PhoneNumberId);          
            props.Add("accountId", AccountId);          
            props.Add("applicationId", ApplicationId);          
            props.Add("phoneNumber", PhoneNumber);          
            props.Add("alias", Alias);          
            props.Add("region", Region);          
            props.Add("country", Country);          
            props.Add("voiceEnabled", VoiceEnabled);          
            props.Add("smsEnabled", SmsEnabled);          
            props.Add("offnet", Offnet);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IncomingNumberResultAllOf);
        }

        /// <summary>
        /// Returns true if IncomingNumberResultAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of IncomingNumberResultAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncomingNumberResultAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Capabilities == input.Capabilities ||
                    (this.Capabilities != null &&
                    this.Capabilities.Equals(input.Capabilities))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.PhoneNumberId == input.PhoneNumberId ||
                    (this.PhoneNumberId != null &&
                    this.PhoneNumberId.Equals(input.PhoneNumberId))
                ) && 
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
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.VoiceEnabled == input.VoiceEnabled ||
                    (this.VoiceEnabled != null &&
                    this.VoiceEnabled.Equals(input.VoiceEnabled))
                ) && 
                (
                    this.SmsEnabled == input.SmsEnabled ||
                    (this.SmsEnabled != null &&
                    this.SmsEnabled.Equals(input.SmsEnabled))
                ) && 
                (
                    this.Offnet == input.Offnet ||
                    (this.Offnet != null &&
                    this.Offnet.Equals(input.Offnet))
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
                if (this.Capabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                }
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                if (this.PhoneNumberId != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumberId.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.VoiceEnabled != null)
                {
                    hashCode = (hashCode * 59) + this.VoiceEnabled.GetHashCode();
                }
                if (this.SmsEnabled != null)
                {
                    hashCode = (hashCode * 59) + this.SmsEnabled.GetHashCode();
                }
                if (this.Offnet != null)
                {
                    hashCode = (hashCode * 59) + this.Offnet.GetHashCode();
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
