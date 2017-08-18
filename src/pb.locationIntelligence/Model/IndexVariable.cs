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
    /// IndexVariable
    /// </summary>
    [DataContract]
    public partial class IndexVariable :  IEquatable<IndexVariable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexVariable" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Score">Score.</param>
        /// <param name="Category">Category.</param>
        /// <param name="Percentile">Percentile.</param>
        public IndexVariable(string Name = null, string Score = null, string Category = null, string Percentile = null)
        {
            this.Name = Name;
            this.Score = Score;
            this.Category = Category;
            this.Percentile = Percentile;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public string Score { get; set; }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        /// <summary>
        /// Gets or Sets Percentile
        /// </summary>
        [DataMember(Name="percentile", EmitDefaultValue=false)]
        public string Percentile { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndexVariable {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Percentile: ").Append(Percentile).Append("\n");
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
            return this.Equals(obj as IndexVariable);
        }

        /// <summary>
        /// Returns true if IndexVariable instances are equal
        /// </summary>
        /// <param name="other">Instance of IndexVariable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexVariable other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Percentile == other.Percentile ||
                    this.Percentile != null &&
                    this.Percentile.Equals(other.Percentile)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Percentile != null)
                    hash = hash * 59 + this.Percentile.GetHashCode();
                return hash;
            }
        }
    }

}
