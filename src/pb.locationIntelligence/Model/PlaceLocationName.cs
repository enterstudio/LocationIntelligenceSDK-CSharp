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
    /// PlaceLocationName
    /// </summary>
    [DataContract]
    public partial class PlaceLocationName :  IEquatable<PlaceLocationName>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceLocationName" /> class.
        /// </summary>
        /// <param name="LangType">LangType.</param>
        /// <param name="LangISOCode">LangISOCode.</param>
        /// <param name="Value">Value.</param>
        public PlaceLocationName(string LangType = null, string LangISOCode = null, string Value = null)
        {
            this.LangType = LangType;
            this.LangISOCode = LangISOCode;
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets LangType
        /// </summary>
        [DataMember(Name="langType", EmitDefaultValue=false)]
        public string LangType { get; set; }
        /// <summary>
        /// Gets or Sets LangISOCode
        /// </summary>
        [DataMember(Name="langISOCode", EmitDefaultValue=false)]
        public string LangISOCode { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlaceLocationName {\n");
            sb.Append("  LangType: ").Append(LangType).Append("\n");
            sb.Append("  LangISOCode: ").Append(LangISOCode).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as PlaceLocationName);
        }

        /// <summary>
        /// Returns true if PlaceLocationName instances are equal
        /// </summary>
        /// <param name="other">Instance of PlaceLocationName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlaceLocationName other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LangType == other.LangType ||
                    this.LangType != null &&
                    this.LangType.Equals(other.LangType)
                ) && 
                (
                    this.LangISOCode == other.LangISOCode ||
                    this.LangISOCode != null &&
                    this.LangISOCode.Equals(other.LangISOCode)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.LangType != null)
                    hash = hash * 59 + this.LangType.GetHashCode();
                if (this.LangISOCode != null)
                    hash = hash * 59 + this.LangISOCode.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }
    }

}
