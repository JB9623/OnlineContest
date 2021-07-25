/* 
 * Polygon API
 *
 * The future of fintech.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = PolygonIO.Client.SwaggerDateConverter;

namespace PolygonIO.Model
{
    /// <summary>
    /// The last available minute bar.
    /// </summary>
    [DataContract]
        public partial class StocksSnapshotTickersMin :  IEquatable<StocksSnapshotTickersMin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StocksSnapshotTickersMin" /> class.
        /// </summary>
        /// <param name="av">The accumulated volume..</param>
        /// <param name="o">The open price for the symbol in the given time period..</param>
        /// <param name="h">The highest price for the symbol in the given time period..</param>
        /// <param name="l">The lowest price for the symbol in the given time period..</param>
        /// <param name="c">The close price for the symbol in the given time period..</param>
        /// <param name="v">The trading volume of the symbol in the given time period..</param>
        /// <param name="vw">The volume weighted average price..</param>
        public StocksSnapshotTickersMin(int? av = default(int?), double? o = default(double?), double? h = default(double?), double? l = default(double?), double? c = default(double?), double? v = default(double?), double? vw = default(double?))
        {
            this.Av = av;
            this.O = o;
            this.H = h;
            this.L = l;
            this.C = c;
            this.V = v;
            this.Vw = vw;
        }
        
        /// <summary>
        /// The accumulated volume.
        /// </summary>
        /// <value>The accumulated volume.</value>
        [DataMember(Name="av", EmitDefaultValue=false)]
        public int? Av { get; set; }

        /// <summary>
        /// The open price for the symbol in the given time period.
        /// </summary>
        /// <value>The open price for the symbol in the given time period.</value>
        [DataMember(Name="o", EmitDefaultValue=false)]
        public double? O { get; set; }

        /// <summary>
        /// The highest price for the symbol in the given time period.
        /// </summary>
        /// <value>The highest price for the symbol in the given time period.</value>
        [DataMember(Name="h", EmitDefaultValue=false)]
        public double? H { get; set; }

        /// <summary>
        /// The lowest price for the symbol in the given time period.
        /// </summary>
        /// <value>The lowest price for the symbol in the given time period.</value>
        [DataMember(Name="l", EmitDefaultValue=false)]
        public double? L { get; set; }

        /// <summary>
        /// The close price for the symbol in the given time period.
        /// </summary>
        /// <value>The close price for the symbol in the given time period.</value>
        [DataMember(Name="c", EmitDefaultValue=false)]
        public double? C { get; set; }

        /// <summary>
        /// The trading volume of the symbol in the given time period.
        /// </summary>
        /// <value>The trading volume of the symbol in the given time period.</value>
        [DataMember(Name="v", EmitDefaultValue=false)]
        public double? V { get; set; }

        /// <summary>
        /// The volume weighted average price.
        /// </summary>
        /// <value>The volume weighted average price.</value>
        [DataMember(Name="vw", EmitDefaultValue=false)]
        public double? Vw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StocksSnapshotTickersMin {\n");
            sb.Append("  Av: ").Append(Av).Append("\n");
            sb.Append("  O: ").Append(O).Append("\n");
            sb.Append("  H: ").Append(H).Append("\n");
            sb.Append("  L: ").Append(L).Append("\n");
            sb.Append("  C: ").Append(C).Append("\n");
            sb.Append("  V: ").Append(V).Append("\n");
            sb.Append("  Vw: ").Append(Vw).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StocksSnapshotTickersMin);
        }

        /// <summary>
        /// Returns true if StocksSnapshotTickersMin instances are equal
        /// </summary>
        /// <param name="input">Instance of StocksSnapshotTickersMin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StocksSnapshotTickersMin input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Av == input.Av ||
                    (this.Av != null &&
                    this.Av.Equals(input.Av))
                ) && 
                (
                    this.O == input.O ||
                    (this.O != null &&
                    this.O.Equals(input.O))
                ) && 
                (
                    this.H == input.H ||
                    (this.H != null &&
                    this.H.Equals(input.H))
                ) && 
                (
                    this.L == input.L ||
                    (this.L != null &&
                    this.L.Equals(input.L))
                ) && 
                (
                    this.C == input.C ||
                    (this.C != null &&
                    this.C.Equals(input.C))
                ) && 
                (
                    this.V == input.V ||
                    (this.V != null &&
                    this.V.Equals(input.V))
                ) && 
                (
                    this.Vw == input.Vw ||
                    (this.Vw != null &&
                    this.Vw.Equals(input.Vw))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Av != null)
                    hashCode = hashCode * 59 + this.Av.GetHashCode();
                if (this.O != null)
                    hashCode = hashCode * 59 + this.O.GetHashCode();
                if (this.H != null)
                    hashCode = hashCode * 59 + this.H.GetHashCode();
                if (this.L != null)
                    hashCode = hashCode * 59 + this.L.GetHashCode();
                if (this.C != null)
                    hashCode = hashCode * 59 + this.C.GetHashCode();
                if (this.V != null)
                    hashCode = hashCode * 59 + this.V.GetHashCode();
                if (this.Vw != null)
                    hashCode = hashCode * 59 + this.Vw.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
