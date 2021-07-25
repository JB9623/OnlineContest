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
using System.ComponentModel.DataAnnotations;

namespace PolygonIO.Model
{
    /// <summary>
    /// TickerResultsResults
    /// </summary>
    [DataContract]
        public partial class TickerResultsResults :  IEquatable<TickerResultsResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TickerResultsResults" /> class.
        /// </summary>
        /// <param name="o">The open price for the symbol in the given time period..</param>
        /// <param name="h">The highest price for the symbol in the given time period..</param>
        /// <param name="l">The lowest price for the symbol in the given time period..</param>
        /// <param name="c">The close price for the symbol in the given time period..</param>
        /// <param name="v">The trading volume of the symbol in the given time period..</param>
        /// <param name="vw">The volume weighted average price..</param>
        /// <param name="t">The Unix Msec timestamp for the start of the aggregate window..</param>
        /// <param name="n">The number of transactions in the aggregate window..</param>
        public TickerResultsResults(double? o = default(double?), double? h = default(double?), double? l = default(double?), double? c = default(double?), double? v = default(double?), double? vw = default(double?), long? t = default(long?), decimal? n = default(decimal?))
        {
            this.O = o;
            this.H = h;
            this.L = l;
            this.C = c;
            this.V = v;
            this.Vw = vw;
            this.T = t;
            this.N = n;
        }
        
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
        /// The Unix Msec timestamp for the start of the aggregate window.
        /// </summary>
        /// <value>The Unix Msec timestamp for the start of the aggregate window.</value>
        [DataMember(Name="t", EmitDefaultValue=false)]
        public long? T { get; set; }

        /*[DataMember(Name = "T", EmitDefaultValue = false)]
        public string Ticker { get; set; }*/

        /// <summary>
        /// The number of transactions in the aggregate window.
        /// </summary>
        /// <value>The number of transactions in the aggregate window.</value>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public decimal? N { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TickerResultsResults {\n");
            //sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  O: ").Append(O).Append("\n");
            sb.Append("  H: ").Append(H).Append("\n");
            sb.Append("  L: ").Append(L).Append("\n");
            sb.Append("  C: ").Append(C).Append("\n");
            sb.Append("  V: ").Append(V).Append("\n");
            sb.Append("  Vw: ").Append(Vw).Append("\n");
            sb.Append("  T: ").Append(T).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
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
            return this.Equals(input as TickerResultsResults);
        }

        /// <summary>
        /// Returns true if TickerResultsResults instances are equal
        /// </summary>
        /// <param name="input">Instance of TickerResultsResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TickerResultsResults input)
        {
            if (input == null)
                return false;

            return
                /*(
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) &&*/
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
                ) && 
                (
                    this.T == input.T ||
                    (this.T != null &&
                    this.T.Equals(input.T))
                ) &&
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
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
                /*if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();*/
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
                if (this.T != null)
                    hashCode = hashCode * 59 + this.T.GetHashCode();
                if (this.N != null)
                    hashCode = hashCode * 59 + this.N.GetHashCode();
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
