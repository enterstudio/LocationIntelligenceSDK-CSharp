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
    /// GeoTaxLocations
    /// </summary>
    [DataContract]
    public partial class GeoTaxLocations :  IEquatable<GeoTaxLocations>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoTaxLocations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GeoTaxLocations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoTaxLocations" /> class.
        /// </summary>
        /// <param name="Geometry">Geometry (required).</param>
        /// <param name="PurchaseAmount">PurchaseAmount.</param>
        /// <param name="ObjectId">ObjectId.</param>
        public GeoTaxLocations(Geometry Geometry = null, string PurchaseAmount = null, string ObjectId = null)
        {
            // to ensure "Geometry" is required (not null)
            if (Geometry == null)
            {
                throw new InvalidDataException("Geometry is a required property for GeoTaxLocations and cannot be null");
            }
            else
            {
                this.Geometry = Geometry;
            }
            this.PurchaseAmount = PurchaseAmount;
            this.ObjectId = ObjectId;
        }
        
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }
        /// <summary>
        /// Gets or Sets PurchaseAmount
        /// </summary>
        [DataMember(Name="purchaseAmount", EmitDefaultValue=false)]
        public string PurchaseAmount { get; set; }
        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoTaxLocations {\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  PurchaseAmount: ").Append(PurchaseAmount).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
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
            return this.Equals(obj as GeoTaxLocations);
        }

        /// <summary>
        /// Returns true if GeoTaxLocations instances are equal
        /// </summary>
        /// <param name="other">Instance of GeoTaxLocations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoTaxLocations other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
                ) && 
                (
                    this.PurchaseAmount == other.PurchaseAmount ||
                    this.PurchaseAmount != null &&
                    this.PurchaseAmount.Equals(other.PurchaseAmount)
                ) && 
                (
                    this.ObjectId == other.ObjectId ||
                    this.ObjectId != null &&
                    this.ObjectId.Equals(other.ObjectId)
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
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                if (this.PurchaseAmount != null)
                    hash = hash * 59 + this.PurchaseAmount.GetHashCode();
                if (this.ObjectId != null)
                    hash = hash * 59 + this.ObjectId.GetHashCode();
                return hash;
            }
        }
    }

}
