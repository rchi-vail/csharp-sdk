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
    /// RecordingResultAllOf
    /// </summary>
    [DataContract(Name = "RecordingResult_allOf")]
    public partial class RecordingResultAllOf : IEquatable<RecordingResultAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingResultAllOf" /> class.
        /// </summary>
        /// <param name="recordingId">String that uniquely identifies this recording resource..</param>
        /// <param name="accountId">ID of the account that created this recording..</param>
        /// <param name="callId">ID of the Call that was recorded. If a Conference was recorded, this value is empty and the conferenceId property is populated..</param>
        /// <param name="durationSec">Length of the recording in seconds..</param>
        /// <param name="conferenceId">ID of the Conference that was recorded. If a Call was recorded, this value is empty and the callId property is populated..</param>
        public RecordingResultAllOf(string recordingId = default(string), string accountId = default(string), string callId = default(string), int? durationSec = default(int?), string conferenceId = default(string))
        {
            this.RecordingId = recordingId;
            this.AccountId = accountId;
            this.CallId = callId;
            this.DurationSec = durationSec;
            this.ConferenceId = conferenceId;
        }

        /// <summary>
        /// String that uniquely identifies this recording resource.
        /// </summary>
        /// <value>String that uniquely identifies this recording resource.</value>
        [DataMember(Name = "recordingId", EmitDefaultValue = true)]
        public string RecordingId { get; set; }

        /// <summary>
        /// ID of the account that created this recording.
        /// </summary>
        /// <value>ID of the account that created this recording.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// ID of the Call that was recorded. If a Conference was recorded, this value is empty and the conferenceId property is populated.
        /// </summary>
        /// <value>ID of the Call that was recorded. If a Conference was recorded, this value is empty and the conferenceId property is populated.</value>
        [DataMember(Name = "callId", EmitDefaultValue = true)]
        public string CallId { get; set; }

        /// <summary>
        /// Length of the recording in seconds.
        /// </summary>
        /// <value>Length of the recording in seconds.</value>
        [DataMember(Name = "durationSec", EmitDefaultValue = true)]
        public int? DurationSec { get; set; }

        /// <summary>
        /// ID of the Conference that was recorded. If a Call was recorded, this value is empty and the callId property is populated.
        /// </summary>
        /// <value>ID of the Conference that was recorded. If a Call was recorded, this value is empty and the callId property is populated.</value>
        [DataMember(Name = "conferenceId", EmitDefaultValue = true)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecordingResultAllOf {\n");
            sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  DurationSec: ").Append(DurationSec).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
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
        /// Retrieve the KVP Dictionary for the RecordingResultAllOf instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("recordingId", RecordingId);          
            props.Add("accountId", AccountId);          
            props.Add("callId", CallId);          
            props.Add("durationSec", DurationSec);          
            props.Add("conferenceId", ConferenceId);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordingResultAllOf);
        }

        /// <summary>
        /// Returns true if RecordingResultAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of RecordingResultAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingResultAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RecordingId == input.RecordingId ||
                    (this.RecordingId != null &&
                    this.RecordingId.Equals(input.RecordingId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CallId == input.CallId ||
                    (this.CallId != null &&
                    this.CallId.Equals(input.CallId))
                ) && 
                (
                    this.DurationSec == input.DurationSec ||
                    (this.DurationSec != null &&
                    this.DurationSec.Equals(input.DurationSec))
                ) && 
                (
                    this.ConferenceId == input.ConferenceId ||
                    (this.ConferenceId != null &&
                    this.ConferenceId.Equals(input.ConferenceId))
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
                if (this.RecordingId != null)
                {
                    hashCode = (hashCode * 59) + this.RecordingId.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.CallId != null)
                {
                    hashCode = (hashCode * 59) + this.CallId.GetHashCode();
                }
                if (this.DurationSec != null)
                {
                    hashCode = (hashCode * 59) + this.DurationSec.GetHashCode();
                }
                if (this.ConferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ConferenceId.GetHashCode();
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
