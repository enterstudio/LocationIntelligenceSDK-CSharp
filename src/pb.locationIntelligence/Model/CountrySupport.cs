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
    /// CountrySupport
    /// </summary>
    [DataContract]
    public partial class CountrySupport :  IEquatable<CountrySupport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountrySupport" /> class.
        /// </summary>
        /// <param name="SupportedCountries">SupportedCountries.</param>
        /// <param name="SupportedDataTypes">SupportedDataTypes.</param>
        public CountrySupport(List<string> SupportedCountries = null, List<string> SupportedDataTypes = null)
        {
            this.SupportedCountries = SupportedCountries;
            this.SupportedDataTypes = SupportedDataTypes;
        }
        
        /// <summary>
        /// Gets or Sets SupportedCountries
        /// </summary>
        [DataMember(Name="supportedCountries", EmitDefaultValue=false)]
        public List<string> SupportedCountries { get; set; }
        /// <summary>
        /// Gets or Sets SupportedDataTypes
        /// </summary>
        [DataMember(Name="supportedDataTypes", EmitDefaultValue=false)]
        public List<string> SupportedDataTypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountrySupport {\n");
            sb.Append("  SupportedCountries: ").Append(SupportedCountries).Append("\n");
            sb.Append("  SupportedDataTypes: ").Append(SupportedDataTypes).Append("\n");
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
            return this.Equals(obj as CountrySupport);
        }

        /// <summary>
        /// Returns true if CountrySupport instances are equal
        /// </summary>
        /// <param name="other">Instance of CountrySupport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountrySupport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SupportedCountries == other.SupportedCountries ||
                    this.SupportedCountries != null &&
                    this.SupportedCountries.SequenceEqual(other.SupportedCountries)
                ) && 
                (
                    this.SupportedDataTypes == other.SupportedDataTypes ||
                    this.SupportedDataTypes != null &&
                    this.SupportedDataTypes.SequenceEqual(other.SupportedDataTypes)
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
                if (this.SupportedCountries != null)
                    hash = hash * 59 + this.SupportedCountries.GetHashCode();
                if (this.SupportedDataTypes != null)
                    hash = hash * 59 + this.SupportedDataTypes.GetHashCode();
                return hash;
            }
        }
    }

}
