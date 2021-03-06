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
    /// Poi
    /// </summary>
    [DataContract]
    public partial class Poi :  IEquatable<Poi>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Poi" /> class.
        /// </summary>
        /// <param name="LangISOCode">LangISOCode.</param>
        /// <param name="LangType">LangType.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Alias">Alias.</param>
        /// <param name="BrandName">BrandName.</param>
        /// <param name="CategoryCode">CategoryCode.</param>
        /// <param name="Open24Hours">Open24Hours.</param>
        /// <param name="ContactDetails">ContactDetails.</param>
        /// <param name="Distance">Distance.</param>
        /// <param name="Latitude">Latitude.</param>
        /// <param name="Longitude">Longitude.</param>
        /// <param name="CustomValue1">CustomValue1.</param>
        /// <param name="CustomValue2">CustomValue2.</param>
        /// <param name="CustomValue3">CustomValue3.</param>
        /// <param name="CustomValue4">CustomValue4.</param>
        /// <param name="CustomValue5">CustomValue5.</param>
        /// <param name="CustomValue6">CustomValue6.</param>
        /// <param name="CustomValue7">CustomValue7.</param>
        /// <param name="CustomValue8">CustomValue8.</param>
        /// <param name="CustomValue9">CustomValue9.</param>
        /// <param name="CustomValue10">CustomValue10.</param>
        public Poi(string LangISOCode = null, string LangType = null, string DisplayName = null, string Name = null, string Alias = null, string BrandName = null, int? CategoryCode = null, string Open24Hours = null, ContactDetails ContactDetails = null, Distance Distance = null, string Latitude = null, string Longitude = null, string CustomValue1 = null, string CustomValue2 = null, string CustomValue3 = null, string CustomValue4 = null, string CustomValue5 = null, string CustomValue6 = null, string CustomValue7 = null, string CustomValue8 = null, string CustomValue9 = null, string CustomValue10 = null)
        {
            this.LangISOCode = LangISOCode;
            this.LangType = LangType;
            this.DisplayName = DisplayName;
            this.Name = Name;
            this.Alias = Alias;
            this.BrandName = BrandName;
            this.CategoryCode = CategoryCode;
            this.Open24Hours = Open24Hours;
            this.ContactDetails = ContactDetails;
            this.Distance = Distance;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.CustomValue1 = CustomValue1;
            this.CustomValue2 = CustomValue2;
            this.CustomValue3 = CustomValue3;
            this.CustomValue4 = CustomValue4;
            this.CustomValue5 = CustomValue5;
            this.CustomValue6 = CustomValue6;
            this.CustomValue7 = CustomValue7;
            this.CustomValue8 = CustomValue8;
            this.CustomValue9 = CustomValue9;
            this.CustomValue10 = CustomValue10;
        }
        
        /// <summary>
        /// Gets or Sets LangISOCode
        /// </summary>
        [DataMember(Name="langISOCode", EmitDefaultValue=false)]
        public string LangISOCode { get; set; }
        /// <summary>
        /// Gets or Sets LangType
        /// </summary>
        [DataMember(Name="langType", EmitDefaultValue=false)]
        public string LangType { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }
        /// <summary>
        /// Gets or Sets BrandName
        /// </summary>
        [DataMember(Name="brandName", EmitDefaultValue=false)]
        public string BrandName { get; set; }
        /// <summary>
        /// Gets or Sets CategoryCode
        /// </summary>
        [DataMember(Name="categoryCode", EmitDefaultValue=false)]
        public int? CategoryCode { get; set; }
        /// <summary>
        /// Gets or Sets Open24Hours
        /// </summary>
        [DataMember(Name="open24Hours", EmitDefaultValue=false)]
        public string Open24Hours { get; set; }
        /// <summary>
        /// Gets or Sets ContactDetails
        /// </summary>
        [DataMember(Name="contactDetails", EmitDefaultValue=false)]
        public ContactDetails ContactDetails { get; set; }
        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public Distance Distance { get; set; }
        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }
        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }
        /// <summary>
        /// Gets or Sets CustomValue1
        /// </summary>
        [DataMember(Name="customValue1", EmitDefaultValue=false)]
        public string CustomValue1 { get; set; }
        /// <summary>
        /// Gets or Sets CustomValue2
        /// </summary>
        [DataMember(Name="customValue2", EmitDefaultValue=false)]
        public string CustomValue2 { get; set; }
        /// <summary>
        /// Gets or Sets CustomValue3
        /// </summary>
        [DataMember(Name="customValue3", EmitDefaultValue=false)]
        public string CustomValue3 { get; set; }
        /// <summary>
        /// Gets or Sets CustomValue4
        /// </summary>
        [DataMember(Name="customValue4", EmitDefaultValue=false)]
        public string CustomValue4 { get; set; }
        /// <summary>
        /// Gets or Sets CustomValue5
        /// </summary>
        [DataMember(Name="customValue5", EmitDefaultValue=false)]
        public string CustomValue5 { get; set; }
        /// <summary>
        /// Gets or Sets CustomValue6
        /// </summary>
        [DataMember(Name="customValue6", EmitDefaultValue=false)]
        public string CustomValue6 { get; set; }
        /// <summary>
        /// Gets or Sets CustomValue7
        /// </summary>
        [DataMember(Name="customValue7", EmitDefaultValue=false)]
        public string CustomValue7 { get; set; }
        /// <summary>
        /// Gets or Sets CustomValue8
        /// </summary>
        [DataMember(Name="customValue8", EmitDefaultValue=false)]
        public string CustomValue8 { get; set; }
        /// <summary>
        /// Gets or Sets CustomValue9
        /// </summary>
        [DataMember(Name="customValue9", EmitDefaultValue=false)]
        public string CustomValue9 { get; set; }
        /// <summary>
        /// Gets or Sets CustomValue10
        /// </summary>
        [DataMember(Name="customValue10", EmitDefaultValue=false)]
        public string CustomValue10 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Poi {\n");
            sb.Append("  LangISOCode: ").Append(LangISOCode).Append("\n");
            sb.Append("  LangType: ").Append(LangType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  Open24Hours: ").Append(Open24Hours).Append("\n");
            sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  CustomValue1: ").Append(CustomValue1).Append("\n");
            sb.Append("  CustomValue2: ").Append(CustomValue2).Append("\n");
            sb.Append("  CustomValue3: ").Append(CustomValue3).Append("\n");
            sb.Append("  CustomValue4: ").Append(CustomValue4).Append("\n");
            sb.Append("  CustomValue5: ").Append(CustomValue5).Append("\n");
            sb.Append("  CustomValue6: ").Append(CustomValue6).Append("\n");
            sb.Append("  CustomValue7: ").Append(CustomValue7).Append("\n");
            sb.Append("  CustomValue8: ").Append(CustomValue8).Append("\n");
            sb.Append("  CustomValue9: ").Append(CustomValue9).Append("\n");
            sb.Append("  CustomValue10: ").Append(CustomValue10).Append("\n");
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
            return this.Equals(obj as Poi);
        }

        /// <summary>
        /// Returns true if Poi instances are equal
        /// </summary>
        /// <param name="other">Instance of Poi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Poi other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LangISOCode == other.LangISOCode ||
                    this.LangISOCode != null &&
                    this.LangISOCode.Equals(other.LangISOCode)
                ) && 
                (
                    this.LangType == other.LangType ||
                    this.LangType != null &&
                    this.LangType.Equals(other.LangType)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Alias == other.Alias ||
                    this.Alias != null &&
                    this.Alias.Equals(other.Alias)
                ) && 
                (
                    this.BrandName == other.BrandName ||
                    this.BrandName != null &&
                    this.BrandName.Equals(other.BrandName)
                ) && 
                (
                    this.CategoryCode == other.CategoryCode ||
                    this.CategoryCode != null &&
                    this.CategoryCode.Equals(other.CategoryCode)
                ) && 
                (
                    this.Open24Hours == other.Open24Hours ||
                    this.Open24Hours != null &&
                    this.Open24Hours.Equals(other.Open24Hours)
                ) && 
                (
                    this.ContactDetails == other.ContactDetails ||
                    this.ContactDetails != null &&
                    this.ContactDetails.Equals(other.ContactDetails)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
                ) && 
                (
                    this.CustomValue1 == other.CustomValue1 ||
                    this.CustomValue1 != null &&
                    this.CustomValue1.Equals(other.CustomValue1)
                ) && 
                (
                    this.CustomValue2 == other.CustomValue2 ||
                    this.CustomValue2 != null &&
                    this.CustomValue2.Equals(other.CustomValue2)
                ) && 
                (
                    this.CustomValue3 == other.CustomValue3 ||
                    this.CustomValue3 != null &&
                    this.CustomValue3.Equals(other.CustomValue3)
                ) && 
                (
                    this.CustomValue4 == other.CustomValue4 ||
                    this.CustomValue4 != null &&
                    this.CustomValue4.Equals(other.CustomValue4)
                ) && 
                (
                    this.CustomValue5 == other.CustomValue5 ||
                    this.CustomValue5 != null &&
                    this.CustomValue5.Equals(other.CustomValue5)
                ) && 
                (
                    this.CustomValue6 == other.CustomValue6 ||
                    this.CustomValue6 != null &&
                    this.CustomValue6.Equals(other.CustomValue6)
                ) && 
                (
                    this.CustomValue7 == other.CustomValue7 ||
                    this.CustomValue7 != null &&
                    this.CustomValue7.Equals(other.CustomValue7)
                ) && 
                (
                    this.CustomValue8 == other.CustomValue8 ||
                    this.CustomValue8 != null &&
                    this.CustomValue8.Equals(other.CustomValue8)
                ) && 
                (
                    this.CustomValue9 == other.CustomValue9 ||
                    this.CustomValue9 != null &&
                    this.CustomValue9.Equals(other.CustomValue9)
                ) && 
                (
                    this.CustomValue10 == other.CustomValue10 ||
                    this.CustomValue10 != null &&
                    this.CustomValue10.Equals(other.CustomValue10)
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
                if (this.LangISOCode != null)
                    hash = hash * 59 + this.LangISOCode.GetHashCode();
                if (this.LangType != null)
                    hash = hash * 59 + this.LangType.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Alias != null)
                    hash = hash * 59 + this.Alias.GetHashCode();
                if (this.BrandName != null)
                    hash = hash * 59 + this.BrandName.GetHashCode();
                if (this.CategoryCode != null)
                    hash = hash * 59 + this.CategoryCode.GetHashCode();
                if (this.Open24Hours != null)
                    hash = hash * 59 + this.Open24Hours.GetHashCode();
                if (this.ContactDetails != null)
                    hash = hash * 59 + this.ContactDetails.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                if (this.CustomValue1 != null)
                    hash = hash * 59 + this.CustomValue1.GetHashCode();
                if (this.CustomValue2 != null)
                    hash = hash * 59 + this.CustomValue2.GetHashCode();
                if (this.CustomValue3 != null)
                    hash = hash * 59 + this.CustomValue3.GetHashCode();
                if (this.CustomValue4 != null)
                    hash = hash * 59 + this.CustomValue4.GetHashCode();
                if (this.CustomValue5 != null)
                    hash = hash * 59 + this.CustomValue5.GetHashCode();
                if (this.CustomValue6 != null)
                    hash = hash * 59 + this.CustomValue6.GetHashCode();
                if (this.CustomValue7 != null)
                    hash = hash * 59 + this.CustomValue7.GetHashCode();
                if (this.CustomValue8 != null)
                    hash = hash * 59 + this.CustomValue8.GetHashCode();
                if (this.CustomValue9 != null)
                    hash = hash * 59 + this.CustomValue9.GetHashCode();
                if (this.CustomValue10 != null)
                    hash = hash * 59 + this.CustomValue10.GetHashCode();
                return hash;
            }
        }
    }

}
