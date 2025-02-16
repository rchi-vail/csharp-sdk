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
    /// CreateConferenceAllOf
    /// </summary>
    [DataContract(Name = "CreateConference_allOf")]
    public partial class CreateConferenceAllOf : IEquatable<CreateConferenceAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConferenceAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateConferenceAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConferenceAllOf" /> class.
        /// </summary>
        /// <param name="actionUrl"> This URL is invoked once the Conference is successfully created. Actions on the Conference, such as adding Participants, can be performed via the PerCL script returned in the response.  (required).</param>
        /// <param name="alias">Descriptive name for the Conference. .</param>
        /// <param name="playBeep">Indicates whether to play a beep when a Participant enters or leaves the Conference. either &#x60;always&#x60;, &#x60;never&#x60;, &#x60;entryOnly&#x60;, or &#x60;exitOnly&#x60;. Leaving this unset will make conference default to &#x60;always&#x60; .</param>
        /// <param name="record">When set to &#x60;true&#x60;, the entire Conference is recorded. The &#x60;statusCallbackUrl&#x60; of the Conference will receive a &#x60;conferenceRecordingEnded&#x60; Webhook when the Conference transitions from the &#x60;inProgress&#x60; to empty state..</param>
        /// <param name="statusCallbackUrl">This URL is invoked when the status of the Conference changes or when a recording of the Conference has become available..</param>
        /// <param name="waitUrl">If specified, this URL provides the custom hold music for the Conference when it is in the populated state. This attribute is always fetched using HTTP GET and is fetched just once – when the Conference is created. The URL must be an audio file that is reachable and readable by FreeClimb..</param>
        public CreateConferenceAllOf(string actionUrl = default(string), bool alias = default(bool), string playBeep = default(string), bool record = default(bool), bool statusCallbackUrl = default(bool), string waitUrl = default(string))
        {
            // to ensure "actionUrl" is required (not null)
            if (actionUrl == null) {
                throw new ArgumentNullException("actionUrl is a required property for CreateConferenceAllOf and cannot be null");
            }
            this.ActionUrl = actionUrl;
            this.Alias = alias;
            this.PlayBeep = playBeep;
            this.Record = record;
            this.StatusCallbackUrl = statusCallbackUrl;
            this.WaitUrl = waitUrl;
        }

        /// <summary>
        ///  This URL is invoked once the Conference is successfully created. Actions on the Conference, such as adding Participants, can be performed via the PerCL script returned in the response. 
        /// </summary>
        /// <value> This URL is invoked once the Conference is successfully created. Actions on the Conference, such as adding Participants, can be performed via the PerCL script returned in the response. </value>
        [DataMember(Name = "actionUrl", IsRequired = true, EmitDefaultValue = false)]
        public string ActionUrl { get; set; }

        /// <summary>
        /// Descriptive name for the Conference. 
        /// </summary>
        /// <value>Descriptive name for the Conference. </value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public bool Alias { get; set; }

        /// <summary>
        /// Indicates whether to play a beep when a Participant enters or leaves the Conference. either &#x60;always&#x60;, &#x60;never&#x60;, &#x60;entryOnly&#x60;, or &#x60;exitOnly&#x60;. Leaving this unset will make conference default to &#x60;always&#x60; 
        /// </summary>
        /// <value>Indicates whether to play a beep when a Participant enters or leaves the Conference. either &#x60;always&#x60;, &#x60;never&#x60;, &#x60;entryOnly&#x60;, or &#x60;exitOnly&#x60;. Leaving this unset will make conference default to &#x60;always&#x60; </value>
        [DataMember(Name = "playBeep", EmitDefaultValue = false)]
        public string PlayBeep { get; set; }

        /// <summary>
        /// When set to &#x60;true&#x60;, the entire Conference is recorded. The &#x60;statusCallbackUrl&#x60; of the Conference will receive a &#x60;conferenceRecordingEnded&#x60; Webhook when the Conference transitions from the &#x60;inProgress&#x60; to empty state.
        /// </summary>
        /// <value>When set to &#x60;true&#x60;, the entire Conference is recorded. The &#x60;statusCallbackUrl&#x60; of the Conference will receive a &#x60;conferenceRecordingEnded&#x60; Webhook when the Conference transitions from the &#x60;inProgress&#x60; to empty state.</value>
        [DataMember(Name = "record", EmitDefaultValue = true)]
        public bool Record { get; set; }

        /// <summary>
        /// This URL is invoked when the status of the Conference changes or when a recording of the Conference has become available.
        /// </summary>
        /// <value>This URL is invoked when the status of the Conference changes or when a recording of the Conference has become available.</value>
        [DataMember(Name = "statusCallbackUrl", EmitDefaultValue = true)]
        public bool StatusCallbackUrl { get; set; }

        /// <summary>
        /// If specified, this URL provides the custom hold music for the Conference when it is in the populated state. This attribute is always fetched using HTTP GET and is fetched just once – when the Conference is created. The URL must be an audio file that is reachable and readable by FreeClimb.
        /// </summary>
        /// <value>If specified, this URL provides the custom hold music for the Conference when it is in the populated state. This attribute is always fetched using HTTP GET and is fetched just once – when the Conference is created. The URL must be an audio file that is reachable and readable by FreeClimb.</value>
        [DataMember(Name = "waitUrl", EmitDefaultValue = false)]
        public string WaitUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateConferenceAllOf {\n");
            sb.Append("  ActionUrl: ").Append(ActionUrl).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  PlayBeep: ").Append(PlayBeep).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  StatusCallbackUrl: ").Append(StatusCallbackUrl).Append("\n");
            sb.Append("  WaitUrl: ").Append(WaitUrl).Append("\n");
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
        /// Retrieve the KVP Dictionary for the CreateConferenceAllOf instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("actionUrl", ActionUrl);          
            props.Add("alias", Alias);          
            props.Add("playBeep", PlayBeep);          
            props.Add("record", Record);          
            props.Add("statusCallbackUrl", StatusCallbackUrl);          
            props.Add("waitUrl", WaitUrl);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateConferenceAllOf);
        }

        /// <summary>
        /// Returns true if CreateConferenceAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateConferenceAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateConferenceAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActionUrl == input.ActionUrl ||
                    (this.ActionUrl != null &&
                    this.ActionUrl.Equals(input.ActionUrl))
                ) && 
                (
                    this.Alias == input.Alias ||
                    this.Alias.Equals(input.Alias)
                ) && 
                (
                    this.PlayBeep == input.PlayBeep ||
                    (this.PlayBeep != null &&
                    this.PlayBeep.Equals(input.PlayBeep))
                ) && 
                (
                    this.Record == input.Record ||
                    this.Record.Equals(input.Record)
                ) && 
                (
                    this.StatusCallbackUrl == input.StatusCallbackUrl ||
                    this.StatusCallbackUrl.Equals(input.StatusCallbackUrl)
                ) && 
                (
                    this.WaitUrl == input.WaitUrl ||
                    (this.WaitUrl != null &&
                    this.WaitUrl.Equals(input.WaitUrl))
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
                if (this.ActionUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ActionUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                if (this.PlayBeep != null)
                {
                    hashCode = (hashCode * 59) + this.PlayBeep.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Record.GetHashCode();
                hashCode = (hashCode * 59) + this.StatusCallbackUrl.GetHashCode();
                if (this.WaitUrl != null)
                {
                    hashCode = (hashCode * 59) + this.WaitUrl.GetHashCode();
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
