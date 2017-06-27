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
    /// AHJ
    /// </summary>
    [DataContract]
    public partial class AHJ :  IEquatable<AHJ>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AHJ" /> class.
        /// </summary>
        /// <param name="AhjType">AhjType.</param>
        /// <param name="AhjId">AhjId.</param>
        /// <param name="Agency">Agency.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="Coverage">Coverage.</param>
        /// <param name="ContactPerson">ContactPerson.</param>
        /// <param name="MailingAddress">MailingAddress.</param>
        public AHJ(string AhjType = null, string AhjId = null, string Agency = null, string Phone = null, string Comments = null, Coverage Coverage = null, ContactPerson ContactPerson = null, Address MailingAddress = null)
        {
            this.AhjType = AhjType;
            this.AhjId = AhjId;
            this.Agency = Agency;
            this.Phone = Phone;
            this.Comments = Comments;
            this.Coverage = Coverage;
            this.ContactPerson = ContactPerson;
            this.MailingAddress = MailingAddress;
        }
        
        /// <summary>
        /// Gets or Sets AhjType
        /// </summary>
        [DataMember(Name="ahjType", EmitDefaultValue=false)]
        public string AhjType { get; set; }
        /// <summary>
        /// Gets or Sets AhjId
        /// </summary>
        [DataMember(Name="ahjId", EmitDefaultValue=false)]
        public string AhjId { get; set; }
        /// <summary>
        /// Gets or Sets Agency
        /// </summary>
        [DataMember(Name="agency", EmitDefaultValue=false)]
        public string Agency { get; set; }
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }
        /// <summary>
        /// Gets or Sets Coverage
        /// </summary>
        [DataMember(Name="coverage", EmitDefaultValue=false)]
        public Coverage Coverage { get; set; }
        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name="contactPerson", EmitDefaultValue=false)]
        public ContactPerson ContactPerson { get; set; }
        /// <summary>
        /// Gets or Sets MailingAddress
        /// </summary>
        [DataMember(Name="mailingAddress", EmitDefaultValue=false)]
        public Address MailingAddress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AHJ {\n");
            sb.Append("  AhjType: ").Append(AhjType).Append("\n");
            sb.Append("  AhjId: ").Append(AhjId).Append("\n");
            sb.Append("  Agency: ").Append(Agency).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Coverage: ").Append(Coverage).Append("\n");
            sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
            sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
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
            return this.Equals(obj as AHJ);
        }

        /// <summary>
        /// Returns true if AHJ instances are equal
        /// </summary>
        /// <param name="other">Instance of AHJ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AHJ other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AhjType == other.AhjType ||
                    this.AhjType != null &&
                    this.AhjType.Equals(other.AhjType)
                ) && 
                (
                    this.AhjId == other.AhjId ||
                    this.AhjId != null &&
                    this.AhjId.Equals(other.AhjId)
                ) && 
                (
                    this.Agency == other.Agency ||
                    this.Agency != null &&
                    this.Agency.Equals(other.Agency)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) && 
                (
                    this.Coverage == other.Coverage ||
                    this.Coverage != null &&
                    this.Coverage.Equals(other.Coverage)
                ) && 
                (
                    this.ContactPerson == other.ContactPerson ||
                    this.ContactPerson != null &&
                    this.ContactPerson.Equals(other.ContactPerson)
                ) && 
                (
                    this.MailingAddress == other.MailingAddress ||
                    this.MailingAddress != null &&
                    this.MailingAddress.Equals(other.MailingAddress)
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
                if (this.AhjType != null)
                    hash = hash * 59 + this.AhjType.GetHashCode();
                if (this.AhjId != null)
                    hash = hash * 59 + this.AhjId.GetHashCode();
                if (this.Agency != null)
                    hash = hash * 59 + this.Agency.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                if (this.Coverage != null)
                    hash = hash * 59 + this.Coverage.GetHashCode();
                if (this.ContactPerson != null)
                    hash = hash * 59 + this.ContactPerson.GetHashCode();
                if (this.MailingAddress != null)
                    hash = hash * 59 + this.MailingAddress.GetHashCode();
                return hash;
            }
        }
    }

}
