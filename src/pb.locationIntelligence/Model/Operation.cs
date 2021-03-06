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
    /// Operation
    /// </summary>
    [DataContract]
    public partial class Operation :  IEquatable<Operation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Operation" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="RequiredInputs">RequiredInputs.</param>
        /// <param name="OptionalInputs">OptionalInputs.</param>
        /// <param name="Outputs">Outputs.</param>
        /// <param name="SupportLevels">SupportLevels.</param>
        public Operation(string Name = null, List<InputParameter> RequiredInputs = null, List<InputParameter> OptionalInputs = null, List<OutputParameter> Outputs = null, List<SupportLevel> SupportLevels = null)
        {
            this.Name = Name;
            this.RequiredInputs = RequiredInputs;
            this.OptionalInputs = OptionalInputs;
            this.Outputs = Outputs;
            this.SupportLevels = SupportLevels;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets RequiredInputs
        /// </summary>
        [DataMember(Name="requiredInputs", EmitDefaultValue=false)]
        public List<InputParameter> RequiredInputs { get; set; }
        /// <summary>
        /// Gets or Sets OptionalInputs
        /// </summary>
        [DataMember(Name="optionalInputs", EmitDefaultValue=false)]
        public List<InputParameter> OptionalInputs { get; set; }
        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public List<OutputParameter> Outputs { get; set; }
        /// <summary>
        /// Gets or Sets SupportLevels
        /// </summary>
        [DataMember(Name="supportLevels", EmitDefaultValue=false)]
        public List<SupportLevel> SupportLevels { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operation {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RequiredInputs: ").Append(RequiredInputs).Append("\n");
            sb.Append("  OptionalInputs: ").Append(OptionalInputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  SupportLevels: ").Append(SupportLevels).Append("\n");
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
            return this.Equals(obj as Operation);
        }

        /// <summary>
        /// Returns true if Operation instances are equal
        /// </summary>
        /// <param name="other">Instance of Operation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Operation other)
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
                    this.RequiredInputs == other.RequiredInputs ||
                    this.RequiredInputs != null &&
                    this.RequiredInputs.SequenceEqual(other.RequiredInputs)
                ) && 
                (
                    this.OptionalInputs == other.OptionalInputs ||
                    this.OptionalInputs != null &&
                    this.OptionalInputs.SequenceEqual(other.OptionalInputs)
                ) && 
                (
                    this.Outputs == other.Outputs ||
                    this.Outputs != null &&
                    this.Outputs.SequenceEqual(other.Outputs)
                ) && 
                (
                    this.SupportLevels == other.SupportLevels ||
                    this.SupportLevels != null &&
                    this.SupportLevels.SequenceEqual(other.SupportLevels)
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
                if (this.RequiredInputs != null)
                    hash = hash * 59 + this.RequiredInputs.GetHashCode();
                if (this.OptionalInputs != null)
                    hash = hash * 59 + this.OptionalInputs.GetHashCode();
                if (this.Outputs != null)
                    hash = hash * 59 + this.Outputs.GetHashCode();
                if (this.SupportLevels != null)
                    hash = hash * 59 + this.SupportLevels.GetHashCode();
                return hash;
            }
        }
    }

}
