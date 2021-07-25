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
    /// StocksSnapshotLastQuote
    /// </summary>
    [DataContract]
        public partial class StocksSnapshotLastQuote :  IEquatable<StocksSnapshotLastQuote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StocksSnapshotLastQuote" /> class.
        /// </summary>
        /// <param name="p">The bid price..</param>
        /// <param name="s">The bid size in lots..</param>
        /// <param name="p">The ask price..</param>
        /// <param name="s">The ask size in lots..</param>
        /// <param name="t">The Unix Msec timestamp for the start of the aggregate window..</param>
        public StocksSnapshotLastQuote(double? bp = default(double?), int? bs = default(int?), double? ap = default(double?), int? a_s = default(int?), int? t = default(int?))
        {
            this.bP = bp;
            this.bS = bs;
            this.aP = ap;
            this.aS = a_s;
            this.T = t;
        }
        
        /// <summary>
        /// The bid price.
        /// </summary>
        /// <value>The bid price.</value>
        [DataMember(Name="p", EmitDefaultValue=false)]
        public double? bP { get; set; }

        /// <summary>
        /// The bid size in lots.
        /// </summary>
        /// <value>The bid size in lots.</value>
        [DataMember(Name="s", EmitDefaultValue=false)]
        public int? bS { get; set; }

        /// <summary>
        /// The ask price.
        /// </summary>
        /// <value>The ask price.</value>
        [DataMember(Name="P", EmitDefaultValue=false)]
        public double? aP { get; set; }

        /// <summary>
        /// The ask size in lots.
        /// </summary>
        /// <value>The ask size in lots.</value>
        [DataMember(Name="S", EmitDefaultValue=false)]
        public int? aS { get; set; }

        /// <summary>
        /// The Unix Msec timestamp for the start of the aggregate window.
        /// </summary>
        /// <value>The Unix Msec timestamp for the start of the aggregate window.</value>
        [DataMember(Name="t", EmitDefaultValue=false)]
        public int? T { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StocksSnapshotLastQuote {\n");
            sb.Append("  bP: ").Append(bP).Append("\n");
            sb.Append("  bS: ").Append(bS).Append("\n");
            sb.Append("  aP: ").Append(aP).Append("\n");
            sb.Append("  aS: ").Append(aS).Append("\n");
            sb.Append("  T: ").Append(T).Append("\n");
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
            return this.Equals(input as StocksSnapshotLastQuote);
        }

        /// <summary>
        /// Returns true if StocksSnapshotLastQuote instances are equal
        /// </summary>
        /// <param name="input">Instance of StocksSnapshotLastQuote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StocksSnapshotLastQuote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.bP == input.bP ||
                    (this.bP != null &&
                    this.bP.Equals(input.bP))
                ) && 
                (
                    this.bS == input.bS ||
                    (this.bS != null &&
                    this.bS.Equals(input.bS))
                ) && 
                (
                    this.aP == input.aP ||
                    (this.aP != null &&
                    this.aP.Equals(input.aP))
                ) && 
                (
                    this.aS == input.aS ||
                    (this.aS != null &&
                    this.aS.Equals(input.aS))
                ) && 
                (
                    this.T == input.T ||
                    (this.T != null &&
                    this.T.Equals(input.T))
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
                if (this.bP != null)
                    hashCode = hashCode * 59 + this.bP.GetHashCode();
                if (this.bS != null)
                    hashCode = hashCode * 59 + this.bS.GetHashCode();
                if (this.aP != null)
                    hashCode = hashCode * 59 + this.aP.GetHashCode();
                if (this.aS != null)
                    hashCode = hashCode * 59 + this.aS.GetHashCode();
                if (this.T != null)
                    hashCode = hashCode * 59 + this.T.GetHashCode();
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
