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
    /// TaxRateBatchLocationResponse
    /// </summary>
    [DataContract]
    public partial class TaxRateBatchLocationResponse :  IEquatable<TaxRateBatchLocationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRateBatchLocationResponse" /> class.
        /// </summary>
        /// <param name="ObjectId">ObjectId.</param>
        /// <param name="Confidence">Confidence.</param>
        /// <param name="Jurisdiction">Jurisdiction.</param>
        /// <param name="MatchedAddress">MatchedAddress.</param>
        /// <param name="SalesTax">SalesTax.</param>
        /// <param name="UseTax">UseTax.</param>
        /// <param name="Census">Census.</param>
        public TaxRateBatchLocationResponse(string ObjectId = null, double? Confidence = null, TaxJurisdiction Jurisdiction = null, MatchedAddress MatchedAddress = null, SalesTaxRate SalesTax = null, UseTaxRate UseTax = null, Census Census = null)
        {
            this.ObjectId = ObjectId;
            this.Confidence = Confidence;
            this.Jurisdiction = Jurisdiction;
            this.MatchedAddress = MatchedAddress;
            this.SalesTax = SalesTax;
            this.UseTax = UseTax;
            this.Census = Census;
        }
        
        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double? Confidence { get; set; }
        /// <summary>
        /// Gets or Sets Jurisdiction
        /// </summary>
        [DataMember(Name="jurisdiction", EmitDefaultValue=false)]
        public TaxJurisdiction Jurisdiction { get; set; }
        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public MatchedAddress MatchedAddress { get; set; }
        /// <summary>
        /// Gets or Sets SalesTax
        /// </summary>
        [DataMember(Name="salesTax", EmitDefaultValue=false)]
        public SalesTaxRate SalesTax { get; set; }
        /// <summary>
        /// Gets or Sets UseTax
        /// </summary>
        [DataMember(Name="useTax", EmitDefaultValue=false)]
        public UseTaxRate UseTax { get; set; }
        /// <summary>
        /// Gets or Sets Census
        /// </summary>
        [DataMember(Name="census", EmitDefaultValue=false)]
        public Census Census { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxRateBatchLocationResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
            sb.Append("  SalesTax: ").Append(SalesTax).Append("\n");
            sb.Append("  UseTax: ").Append(UseTax).Append("\n");
            sb.Append("  Census: ").Append(Census).Append("\n");
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
            return this.Equals(obj as TaxRateBatchLocationResponse);
        }

        /// <summary>
        /// Returns true if TaxRateBatchLocationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxRateBatchLocationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRateBatchLocationResponse other)
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
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
                ) && 
                (
                    this.Jurisdiction == other.Jurisdiction ||
                    this.Jurisdiction != null &&
                    this.Jurisdiction.Equals(other.Jurisdiction)
                ) && 
                (
                    this.MatchedAddress == other.MatchedAddress ||
                    this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(other.MatchedAddress)
                ) && 
                (
                    this.SalesTax == other.SalesTax ||
                    this.SalesTax != null &&
                    this.SalesTax.Equals(other.SalesTax)
                ) && 
                (
                    this.UseTax == other.UseTax ||
                    this.UseTax != null &&
                    this.UseTax.Equals(other.UseTax)
                ) && 
                (
                    this.Census == other.Census ||
                    this.Census != null &&
                    this.Census.Equals(other.Census)
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
                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();
                if (this.Jurisdiction != null)
                    hash = hash * 59 + this.Jurisdiction.GetHashCode();
                if (this.MatchedAddress != null)
                    hash = hash * 59 + this.MatchedAddress.GetHashCode();
                if (this.SalesTax != null)
                    hash = hash * 59 + this.SalesTax.GetHashCode();
                if (this.UseTax != null)
                    hash = hash * 59 + this.UseTax.GetHashCode();
                if (this.Census != null)
                    hash = hash * 59 + this.Census.GetHashCode();
                return hash;
            }
        }
    }

}
