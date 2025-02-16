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
    /// QueueMember
    /// </summary>
    [DataContract(Name = "QueueMember")]
    public partial class QueueMember : IEquatable<QueueMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueMember" /> class.
        /// </summary>
        /// <param name="uri">URI for this Queue Member resource, relative to the API base URL..</param>
        /// <param name="callId">ID of the Call associated with this Queue Member..</param>
        /// <param name="waitTime">Number of seconds the Member has been in the queue..</param>
        /// <param name="position">Member&#39;s current position in the Queue, 1 indexed..</param>
        /// <param name="dateEnqueued">Date that the Member was enqueued (GMT), given in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT)..</param>
        public QueueMember(string uri = default(string), string callId = default(string), int? waitTime = default(int?), int? position = default(int?), string dateEnqueued = default(string))
        {
            this.Uri = uri;
            this.CallId = callId;
            this.WaitTime = waitTime;
            this.Position = position;
            this.DateEnqueued = dateEnqueued;
        }

        /// <summary>
        /// URI for this Queue Member resource, relative to the API base URL.
        /// </summary>
        /// <value>URI for this Queue Member resource, relative to the API base URL.</value>
        [DataMember(Name = "uri", EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// ID of the Call associated with this Queue Member.
        /// </summary>
        /// <value>ID of the Call associated with this Queue Member.</value>
        [DataMember(Name = "callId", EmitDefaultValue = true)]
        public string CallId { get; set; }

        /// <summary>
        /// Number of seconds the Member has been in the queue.
        /// </summary>
        /// <value>Number of seconds the Member has been in the queue.</value>
        [DataMember(Name = "waitTime", EmitDefaultValue = true)]
        public int? WaitTime { get; set; }

        /// <summary>
        /// Member&#39;s current position in the Queue, 1 indexed.
        /// </summary>
        /// <value>Member&#39;s current position in the Queue, 1 indexed.</value>
        [DataMember(Name = "position", EmitDefaultValue = true)]
        public int? Position { get; set; }

        /// <summary>
        /// Date that the Member was enqueued (GMT), given in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT).
        /// </summary>
        /// <value>Date that the Member was enqueued (GMT), given in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT).</value>
        [DataMember(Name = "dateEnqueued", EmitDefaultValue = true)]
        public string DateEnqueued { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueueMember {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  WaitTime: ").Append(WaitTime).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  DateEnqueued: ").Append(DateEnqueued).Append("\n");
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
        /// Retrieve the KVP Dictionary for the QueueMember instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("uri", Uri);          
            props.Add("callId", CallId);          
            props.Add("waitTime", WaitTime);          
            props.Add("position", Position);          
            props.Add("dateEnqueued", DateEnqueued);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueueMember);
        }

        /// <summary>
        /// Returns true if QueueMember instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueMember input)
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
                    this.CallId == input.CallId ||
                    (this.CallId != null &&
                    this.CallId.Equals(input.CallId))
                ) && 
                (
                    this.WaitTime == input.WaitTime ||
                    (this.WaitTime != null &&
                    this.WaitTime.Equals(input.WaitTime))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.DateEnqueued == input.DateEnqueued ||
                    (this.DateEnqueued != null &&
                    this.DateEnqueued.Equals(input.DateEnqueued))
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
                if (this.CallId != null)
                {
                    hashCode = (hashCode * 59) + this.CallId.GetHashCode();
                }
                if (this.WaitTime != null)
                {
                    hashCode = (hashCode * 59) + this.WaitTime.GetHashCode();
                }
                if (this.Position != null)
                {
                    hashCode = (hashCode * 59) + this.Position.GetHashCode();
                }
                if (this.DateEnqueued != null)
                {
                    hashCode = (hashCode * 59) + this.DateEnqueued.GetHashCode();
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
