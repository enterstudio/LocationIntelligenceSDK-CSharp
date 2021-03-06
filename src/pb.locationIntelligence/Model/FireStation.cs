/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 4.6.0
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
    /// FireStation
    /// </summary>
    [DataContract]
    public partial class FireStation :  IEquatable<FireStation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireStation" /> class.
        /// </summary>
        /// <param name="NumWithinDepartment">NumWithinDepartment.</param>
        /// <param name="LocationReference">LocationReference.</param>
        /// <param name="TravelDistance">TravelDistance.</param>
        /// <param name="TravelTime">TravelTime.</param>
        /// <param name="ContactDetails">ContactDetails.</param>
        /// <param name="FireDepartment">FireDepartment.</param>
        /// <param name="Geometry">Geometry.</param>
        public FireStation(string NumWithinDepartment = null, string LocationReference = null, Distance TravelDistance = null, Time TravelTime = null, FireStationContactDetails ContactDetails = null, FireDepartment FireDepartment = null, Geometry Geometry = null)
        {
            this.NumWithinDepartment = NumWithinDepartment;
            this.LocationReference = LocationReference;
            this.TravelDistance = TravelDistance;
            this.TravelTime = TravelTime;
            this.ContactDetails = ContactDetails;
            this.FireDepartment = FireDepartment;
            this.Geometry = Geometry;
        }
        
        /// <summary>
        /// Gets or Sets NumWithinDepartment
        /// </summary>
        [DataMember(Name="numWithinDepartment", EmitDefaultValue=false)]
        public string NumWithinDepartment { get; set; }
        /// <summary>
        /// Gets or Sets LocationReference
        /// </summary>
        [DataMember(Name="locationReference", EmitDefaultValue=false)]
        public string LocationReference { get; set; }
        /// <summary>
        /// Gets or Sets TravelDistance
        /// </summary>
        [DataMember(Name="travelDistance", EmitDefaultValue=false)]
        public Distance TravelDistance { get; set; }
        /// <summary>
        /// Gets or Sets TravelTime
        /// </summary>
        [DataMember(Name="travelTime", EmitDefaultValue=false)]
        public Time TravelTime { get; set; }
        /// <summary>
        /// Gets or Sets ContactDetails
        /// </summary>
        [DataMember(Name="contactDetails", EmitDefaultValue=false)]
        public FireStationContactDetails ContactDetails { get; set; }
        /// <summary>
        /// Gets or Sets FireDepartment
        /// </summary>
        [DataMember(Name="fireDepartment", EmitDefaultValue=false)]
        public FireDepartment FireDepartment { get; set; }
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireStation {\n");
            sb.Append("  NumWithinDepartment: ").Append(NumWithinDepartment).Append("\n");
            sb.Append("  LocationReference: ").Append(LocationReference).Append("\n");
            sb.Append("  TravelDistance: ").Append(TravelDistance).Append("\n");
            sb.Append("  TravelTime: ").Append(TravelTime).Append("\n");
            sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
            sb.Append("  FireDepartment: ").Append(FireDepartment).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
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
            return this.Equals(obj as FireStation);
        }

        /// <summary>
        /// Returns true if FireStation instances are equal
        /// </summary>
        /// <param name="other">Instance of FireStation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireStation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumWithinDepartment == other.NumWithinDepartment ||
                    this.NumWithinDepartment != null &&
                    this.NumWithinDepartment.Equals(other.NumWithinDepartment)
                ) && 
                (
                    this.LocationReference == other.LocationReference ||
                    this.LocationReference != null &&
                    this.LocationReference.Equals(other.LocationReference)
                ) && 
                (
                    this.TravelDistance == other.TravelDistance ||
                    this.TravelDistance != null &&
                    this.TravelDistance.Equals(other.TravelDistance)
                ) && 
                (
                    this.TravelTime == other.TravelTime ||
                    this.TravelTime != null &&
                    this.TravelTime.Equals(other.TravelTime)
                ) && 
                (
                    this.ContactDetails == other.ContactDetails ||
                    this.ContactDetails != null &&
                    this.ContactDetails.Equals(other.ContactDetails)
                ) && 
                (
                    this.FireDepartment == other.FireDepartment ||
                    this.FireDepartment != null &&
                    this.FireDepartment.Equals(other.FireDepartment)
                ) && 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
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
                if (this.NumWithinDepartment != null)
                    hash = hash * 59 + this.NumWithinDepartment.GetHashCode();
                if (this.LocationReference != null)
                    hash = hash * 59 + this.LocationReference.GetHashCode();
                if (this.TravelDistance != null)
                    hash = hash * 59 + this.TravelDistance.GetHashCode();
                if (this.TravelTime != null)
                    hash = hash * 59 + this.TravelTime.GetHashCode();
                if (this.ContactDetails != null)
                    hash = hash * 59 + this.ContactDetails.GetHashCode();
                if (this.FireDepartment != null)
                    hash = hash * 59 + this.FireDepartment.GetHashCode();
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                return hash;
            }
        }
    }

}
