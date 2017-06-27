/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 3.5.0
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
    /// FloodRiskResponse
    /// </summary>
    [DataContract]
    public partial class FloodRiskResponse :  IEquatable<FloodRiskResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloodRiskResponse" /> class.
        /// </summary>
        /// <param name="ObjectId">ObjectId.</param>
        /// <param name="State">State.</param>
        /// <param name="FloodZone">FloodZone.</param>
        /// <param name="Community">Community.</param>
        /// <param name="Boundary">Boundary.</param>
        /// <param name="MatchedAddress">MatchedAddress.</param>
        public FloodRiskResponse(string ObjectId = null, State State = null, FloodZone FloodZone = null, Community Community = null, FloodBoundary Boundary = null, Address MatchedAddress = null)
        {
            this.ObjectId = ObjectId;
            this.State = State;
            this.FloodZone = FloodZone;
            this.Community = Community;
            this.Boundary = Boundary;
            this.MatchedAddress = MatchedAddress;
        }
        
        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public State State { get; set; }
        /// <summary>
        /// Gets or Sets FloodZone
        /// </summary>
        [DataMember(Name="floodZone", EmitDefaultValue=false)]
        public FloodZone FloodZone { get; set; }
        /// <summary>
        /// Gets or Sets Community
        /// </summary>
        [DataMember(Name="community", EmitDefaultValue=false)]
        public Community Community { get; set; }
        /// <summary>
        /// Gets or Sets Boundary
        /// </summary>
        [DataMember(Name="boundary", EmitDefaultValue=false)]
        public FloodBoundary Boundary { get; set; }
        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public Address MatchedAddress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FloodRiskResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  FloodZone: ").Append(FloodZone).Append("\n");
            sb.Append("  Community: ").Append(Community).Append("\n");
            sb.Append("  Boundary: ").Append(Boundary).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
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
            return this.Equals(obj as FloodRiskResponse);
        }

        /// <summary>
        /// Returns true if FloodRiskResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FloodRiskResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FloodRiskResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ObjectId == other.ObjectId ||
                    this.ObjectId != null &&
                    this.ObjectId.Equals(other.ObjectId)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.FloodZone == other.FloodZone ||
                    this.FloodZone != null &&
                    this.FloodZone.Equals(other.FloodZone)
                ) && 
                (
                    this.Community == other.Community ||
                    this.Community != null &&
                    this.Community.Equals(other.Community)
                ) && 
                (
                    this.Boundary == other.Boundary ||
                    this.Boundary != null &&
                    this.Boundary.Equals(other.Boundary)
                ) && 
                (
                    this.MatchedAddress == other.MatchedAddress ||
                    this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(other.MatchedAddress)
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
                if (this.ObjectId != null)
                    hash = hash * 59 + this.ObjectId.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.FloodZone != null)
                    hash = hash * 59 + this.FloodZone.GetHashCode();
                if (this.Community != null)
                    hash = hash * 59 + this.Community.GetHashCode();
                if (this.Boundary != null)
                    hash = hash * 59 + this.Boundary.GetHashCode();
                if (this.MatchedAddress != null)
                    hash = hash * 59 + this.MatchedAddress.GetHashCode();
                return hash;
            }
        }
    }

}
