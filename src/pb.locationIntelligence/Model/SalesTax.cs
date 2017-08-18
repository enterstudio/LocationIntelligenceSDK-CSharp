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
    /// SalesTax
    /// </summary>
    [DataContract]
    public partial class SalesTax :  IEquatable<SalesTax>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesTax" /> class.
        /// </summary>
        /// <param name="TotalTaxRate">TotalTaxRate.</param>
        /// <param name="TotalTaxAmount">TotalTaxAmount.</param>
        /// <param name="StateTaxRate">StateTaxRate.</param>
        /// <param name="StateTaxAmount">StateTaxAmount.</param>
        /// <param name="CountyTaxRate">CountyTaxRate.</param>
        /// <param name="CountyTaxAmount">CountyTaxAmount.</param>
        /// <param name="MunicipalTaxRate">MunicipalTaxRate.</param>
        /// <param name="MunicipalTaxAmount">MunicipalTaxAmount.</param>
        /// <param name="SpdsTax">SpdsTax.</param>
        /// <param name="SpecialTaxRulesApplied">SpecialTaxRulesApplied (default to false).</param>
        /// <param name="SpecialTaxRulesDescriptor">SpecialTaxRulesDescriptor.</param>
        public SalesTax(double? TotalTaxRate = null, double? TotalTaxAmount = null, double? StateTaxRate = null, double? StateTaxAmount = null, double? CountyTaxRate = null, double? CountyTaxAmount = null, double? MunicipalTaxRate = null, double? MunicipalTaxAmount = null, List<SpecialPurposeDistrictTax> SpdsTax = null, bool? SpecialTaxRulesApplied = null, string SpecialTaxRulesDescriptor = null)
        {
            this.TotalTaxRate = TotalTaxRate;
            this.TotalTaxAmount = TotalTaxAmount;
            this.StateTaxRate = StateTaxRate;
            this.StateTaxAmount = StateTaxAmount;
            this.CountyTaxRate = CountyTaxRate;
            this.CountyTaxAmount = CountyTaxAmount;
            this.MunicipalTaxRate = MunicipalTaxRate;
            this.MunicipalTaxAmount = MunicipalTaxAmount;
            this.SpdsTax = SpdsTax;
            // use default value if no "SpecialTaxRulesApplied" provided
            if (SpecialTaxRulesApplied == null)
            {
                this.SpecialTaxRulesApplied = false;
            }
            else
            {
                this.SpecialTaxRulesApplied = SpecialTaxRulesApplied;
            }
            this.SpecialTaxRulesDescriptor = SpecialTaxRulesDescriptor;
        }
        
        /// <summary>
        /// Gets or Sets TotalTaxRate
        /// </summary>
        [DataMember(Name="totalTaxRate", EmitDefaultValue=false)]
        public double? TotalTaxRate { get; set; }
        /// <summary>
        /// Gets or Sets TotalTaxAmount
        /// </summary>
        [DataMember(Name="totalTaxAmount", EmitDefaultValue=false)]
        public double? TotalTaxAmount { get; set; }
        /// <summary>
        /// Gets or Sets StateTaxRate
        /// </summary>
        [DataMember(Name="stateTaxRate", EmitDefaultValue=false)]
        public double? StateTaxRate { get; set; }
        /// <summary>
        /// Gets or Sets StateTaxAmount
        /// </summary>
        [DataMember(Name="stateTaxAmount", EmitDefaultValue=false)]
        public double? StateTaxAmount { get; set; }
        /// <summary>
        /// Gets or Sets CountyTaxRate
        /// </summary>
        [DataMember(Name="countyTaxRate", EmitDefaultValue=false)]
        public double? CountyTaxRate { get; set; }
        /// <summary>
        /// Gets or Sets CountyTaxAmount
        /// </summary>
        [DataMember(Name="countyTaxAmount", EmitDefaultValue=false)]
        public double? CountyTaxAmount { get; set; }
        /// <summary>
        /// Gets or Sets MunicipalTaxRate
        /// </summary>
        [DataMember(Name="municipalTaxRate", EmitDefaultValue=false)]
        public double? MunicipalTaxRate { get; set; }
        /// <summary>
        /// Gets or Sets MunicipalTaxAmount
        /// </summary>
        [DataMember(Name="municipalTaxAmount", EmitDefaultValue=false)]
        public double? MunicipalTaxAmount { get; set; }
        /// <summary>
        /// Gets or Sets SpdsTax
        /// </summary>
        [DataMember(Name="spdsTax", EmitDefaultValue=false)]
        public List<SpecialPurposeDistrictTax> SpdsTax { get; set; }
        /// <summary>
        /// Gets or Sets SpecialTaxRulesApplied
        /// </summary>
        [DataMember(Name="specialTaxRulesApplied", EmitDefaultValue=false)]
        public bool? SpecialTaxRulesApplied { get; set; }
        /// <summary>
        /// Gets or Sets SpecialTaxRulesDescriptor
        /// </summary>
        [DataMember(Name="specialTaxRulesDescriptor", EmitDefaultValue=false)]
        public string SpecialTaxRulesDescriptor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesTax {\n");
            sb.Append("  TotalTaxRate: ").Append(TotalTaxRate).Append("\n");
            sb.Append("  TotalTaxAmount: ").Append(TotalTaxAmount).Append("\n");
            sb.Append("  StateTaxRate: ").Append(StateTaxRate).Append("\n");
            sb.Append("  StateTaxAmount: ").Append(StateTaxAmount).Append("\n");
            sb.Append("  CountyTaxRate: ").Append(CountyTaxRate).Append("\n");
            sb.Append("  CountyTaxAmount: ").Append(CountyTaxAmount).Append("\n");
            sb.Append("  MunicipalTaxRate: ").Append(MunicipalTaxRate).Append("\n");
            sb.Append("  MunicipalTaxAmount: ").Append(MunicipalTaxAmount).Append("\n");
            sb.Append("  SpdsTax: ").Append(SpdsTax).Append("\n");
            sb.Append("  SpecialTaxRulesApplied: ").Append(SpecialTaxRulesApplied).Append("\n");
            sb.Append("  SpecialTaxRulesDescriptor: ").Append(SpecialTaxRulesDescriptor).Append("\n");
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
            return this.Equals(obj as SalesTax);
        }

        /// <summary>
        /// Returns true if SalesTax instances are equal
        /// </summary>
        /// <param name="other">Instance of SalesTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesTax other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalTaxRate == other.TotalTaxRate ||
                    this.TotalTaxRate != null &&
                    this.TotalTaxRate.Equals(other.TotalTaxRate)
                ) && 
                (
                    this.TotalTaxAmount == other.TotalTaxAmount ||
                    this.TotalTaxAmount != null &&
                    this.TotalTaxAmount.Equals(other.TotalTaxAmount)
                ) && 
                (
                    this.StateTaxRate == other.StateTaxRate ||
                    this.StateTaxRate != null &&
                    this.StateTaxRate.Equals(other.StateTaxRate)
                ) && 
                (
                    this.StateTaxAmount == other.StateTaxAmount ||
                    this.StateTaxAmount != null &&
                    this.StateTaxAmount.Equals(other.StateTaxAmount)
                ) && 
                (
                    this.CountyTaxRate == other.CountyTaxRate ||
                    this.CountyTaxRate != null &&
                    this.CountyTaxRate.Equals(other.CountyTaxRate)
                ) && 
                (
                    this.CountyTaxAmount == other.CountyTaxAmount ||
                    this.CountyTaxAmount != null &&
                    this.CountyTaxAmount.Equals(other.CountyTaxAmount)
                ) && 
                (
                    this.MunicipalTaxRate == other.MunicipalTaxRate ||
                    this.MunicipalTaxRate != null &&
                    this.MunicipalTaxRate.Equals(other.MunicipalTaxRate)
                ) && 
                (
                    this.MunicipalTaxAmount == other.MunicipalTaxAmount ||
                    this.MunicipalTaxAmount != null &&
                    this.MunicipalTaxAmount.Equals(other.MunicipalTaxAmount)
                ) && 
                (
                    this.SpdsTax == other.SpdsTax ||
                    this.SpdsTax != null &&
                    this.SpdsTax.SequenceEqual(other.SpdsTax)
                ) && 
                (
                    this.SpecialTaxRulesApplied == other.SpecialTaxRulesApplied ||
                    this.SpecialTaxRulesApplied != null &&
                    this.SpecialTaxRulesApplied.Equals(other.SpecialTaxRulesApplied)
                ) && 
                (
                    this.SpecialTaxRulesDescriptor == other.SpecialTaxRulesDescriptor ||
                    this.SpecialTaxRulesDescriptor != null &&
                    this.SpecialTaxRulesDescriptor.Equals(other.SpecialTaxRulesDescriptor)
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
                if (this.TotalTaxRate != null)
                    hash = hash * 59 + this.TotalTaxRate.GetHashCode();
                if (this.TotalTaxAmount != null)
                    hash = hash * 59 + this.TotalTaxAmount.GetHashCode();
                if (this.StateTaxRate != null)
                    hash = hash * 59 + this.StateTaxRate.GetHashCode();
                if (this.StateTaxAmount != null)
                    hash = hash * 59 + this.StateTaxAmount.GetHashCode();
                if (this.CountyTaxRate != null)
                    hash = hash * 59 + this.CountyTaxRate.GetHashCode();
                if (this.CountyTaxAmount != null)
                    hash = hash * 59 + this.CountyTaxAmount.GetHashCode();
                if (this.MunicipalTaxRate != null)
                    hash = hash * 59 + this.MunicipalTaxRate.GetHashCode();
                if (this.MunicipalTaxAmount != null)
                    hash = hash * 59 + this.MunicipalTaxAmount.GetHashCode();
                if (this.SpdsTax != null)
                    hash = hash * 59 + this.SpdsTax.GetHashCode();
                if (this.SpecialTaxRulesApplied != null)
                    hash = hash * 59 + this.SpecialTaxRulesApplied.GetHashCode();
                if (this.SpecialTaxRulesDescriptor != null)
                    hash = hash * 59 + this.SpecialTaxRulesDescriptor.GetHashCode();
                return hash;
            }
        }
    }

}
