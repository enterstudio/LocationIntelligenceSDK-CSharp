/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 3.6.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace pb.locationIntelligence.Model
{
    /// <summary>
    /// FireHistory
    /// </summary>
    [DataContract]
    public partial class FireHistory :  IEquatable<FireHistory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireHistory" /> class.
        /// </summary>
        /// <param name="StateCode">StateCode.</param>
        /// <param name="PostCode">PostCode.</param>
        /// <param name="Events">Events.</param>
        public FireHistory(string StateCode = null, string PostCode = null, FireEventsResponse Events = null)
        {
            this.StateCode = StateCode;
            this.PostCode = PostCode;
            this.Events = Events;
        }
        
        /// <summary>
        /// Gets or Sets StateCode
        /// </summary>
        [DataMember(Name="stateCode", EmitDefaultValue=false)]
        public string StateCode { get; set; }
        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }
        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public FireEventsResponse Events { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireHistory {\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FireHistory);
        }

        /// <summary>
        /// Returns true if FireHistory instances are equal
        /// </summary>
        /// <param name="other">Instance of FireHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireHistory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StateCode == other.StateCode ||
                    this.StateCode != null &&
                    this.StateCode.Equals(other.StateCode)
                ) && 
                (
                    this.PostCode == other.PostCode ||
                    this.PostCode != null &&
                    this.PostCode.Equals(other.PostCode)
                ) && 
                (
                    this.Events == other.Events ||
                    this.Events != null &&
                    this.Events.Equals(other.Events)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.StateCode != null)
                    hash = hash * 59 + this.StateCode.GetHashCode();
                if (this.PostCode != null)
                    hash = hash * 59 + this.PostCode.GetHashCode();
                if (this.Events != null)
                    hash = hash * 59 + this.Events.GetHashCode();
                return hash;
            }
        }
    }

}
