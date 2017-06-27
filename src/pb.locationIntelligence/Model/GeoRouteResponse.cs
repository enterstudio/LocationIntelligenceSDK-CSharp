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
    /// GeoRouteResponse
    /// </summary>
    [DataContract]
    public partial class GeoRouteResponse :  IEquatable<GeoRouteResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoRouteResponse" /> class.
        /// </summary>
        /// <param name="DirectionsStyle">DirectionsStyle.</param>
        /// <param name="Distance">Distance.</param>
        /// <param name="DistanceUnit">DistanceUnit.</param>
        /// <param name="Language">Language.</param>
        /// <param name="TimeUnit">TimeUnit.</param>
        /// <param name="Time">Time.</param>
        /// <param name="Geometry">Geometry.</param>
        /// <param name="RouteDirections">RouteDirections.</param>
        public GeoRouteResponse(string DirectionsStyle = null, decimal? Distance = null, string DistanceUnit = null, string Language = null, string TimeUnit = null, decimal? Time = null, RouteGeometry Geometry = null, RouteDirections RouteDirections = null)
        {
            this.DirectionsStyle = DirectionsStyle;
            this.Distance = Distance;
            this.DistanceUnit = DistanceUnit;
            this.Language = Language;
            this.TimeUnit = TimeUnit;
            this.Time = Time;
            this.Geometry = Geometry;
            this.RouteDirections = RouteDirections;
        }
        
        /// <summary>
        /// Gets or Sets DirectionsStyle
        /// </summary>
        [DataMember(Name="directionsStyle", EmitDefaultValue=false)]
        public string DirectionsStyle { get; set; }
        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public decimal? Distance { get; set; }
        /// <summary>
        /// Gets or Sets DistanceUnit
        /// </summary>
        [DataMember(Name="distanceUnit", EmitDefaultValue=false)]
        public string DistanceUnit { get; set; }
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        /// <summary>
        /// Gets or Sets TimeUnit
        /// </summary>
        [DataMember(Name="timeUnit", EmitDefaultValue=false)]
        public string TimeUnit { get; set; }
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public decimal? Time { get; set; }
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public RouteGeometry Geometry { get; set; }
        /// <summary>
        /// Gets or Sets RouteDirections
        /// </summary>
        [DataMember(Name="routeDirections", EmitDefaultValue=false)]
        public RouteDirections RouteDirections { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoRouteResponse {\n");
            sb.Append("  DirectionsStyle: ").Append(DirectionsStyle).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  DistanceUnit: ").Append(DistanceUnit).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  TimeUnit: ").Append(TimeUnit).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  RouteDirections: ").Append(RouteDirections).Append("\n");
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
            return this.Equals(obj as GeoRouteResponse);
        }

        /// <summary>
        /// Returns true if GeoRouteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GeoRouteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoRouteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DirectionsStyle == other.DirectionsStyle ||
                    this.DirectionsStyle != null &&
                    this.DirectionsStyle.Equals(other.DirectionsStyle)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.DistanceUnit == other.DistanceUnit ||
                    this.DistanceUnit != null &&
                    this.DistanceUnit.Equals(other.DistanceUnit)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.TimeUnit == other.TimeUnit ||
                    this.TimeUnit != null &&
                    this.TimeUnit.Equals(other.TimeUnit)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
                ) && 
                (
                    this.RouteDirections == other.RouteDirections ||
                    this.RouteDirections != null &&
                    this.RouteDirections.Equals(other.RouteDirections)
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
                if (this.DirectionsStyle != null)
                    hash = hash * 59 + this.DirectionsStyle.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.DistanceUnit != null)
                    hash = hash * 59 + this.DistanceUnit.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.TimeUnit != null)
                    hash = hash * 59 + this.TimeUnit.GetHashCode();
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                if (this.RouteDirections != null)
                    hash = hash * 59 + this.RouteDirections.GetHashCode();
                return hash;
            }
        }
    }

}
