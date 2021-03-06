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
    /// MarketStatusExchanges
    /// </summary>
    [DataContract]
        public partial class MarketStatusExchanges :  IEquatable<MarketStatusExchanges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketStatusExchanges" /> class.
        /// </summary>
        /// <param name="nyse">The status of the NYSE market..</param>
        /// <param name="nasdaq">The status of the Nasdaq market..</param>
        /// <param name="otc">The status of the OTC market..</param>
        public MarketStatusExchanges(string nyse = default(string), string nasdaq = default(string), string otc = default(string))
        {
            this.Nyse = nyse;
            this.Nasdaq = nasdaq;
            this.Otc = otc;
        }
        
        /// <summary>
        /// The status of the NYSE market.
        /// </summary>
        /// <value>The status of the NYSE market.</value>
        [DataMember(Name="nyse", EmitDefaultValue=false)]
        public string Nyse { get; set; }

        /// <summary>
        /// The status of the Nasdaq market.
        /// </summary>
        /// <value>The status of the Nasdaq market.</value>
        [DataMember(Name="nasdaq", EmitDefaultValue=false)]
        public string Nasdaq { get; set; }

        /// <summary>
        /// The status of the OTC market.
        /// </summary>
        /// <value>The status of the OTC market.</value>
        [DataMember(Name="otc", EmitDefaultValue=false)]
        public string Otc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketStatusExchanges {\n");
            sb.Append("  Nyse: ").Append(Nyse).Append("\n");
            sb.Append("  Nasdaq: ").Append(Nasdaq).Append("\n");
            sb.Append("  Otc: ").Append(Otc).Append("\n");
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
            return this.Equals(input as MarketStatusExchanges);
        }

        /// <summary>
        /// Returns true if MarketStatusExchanges instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketStatusExchanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketStatusExchanges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nyse == input.Nyse ||
                    (this.Nyse != null &&
                    this.Nyse.Equals(input.Nyse))
                ) && 
                (
                    this.Nasdaq == input.Nasdaq ||
                    (this.Nasdaq != null &&
                    this.Nasdaq.Equals(input.Nasdaq))
                ) && 
                (
                    this.Otc == input.Otc ||
                    (this.Otc != null &&
                    this.Otc.Equals(input.Otc))
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
                if (this.Nyse != null)
                    hashCode = hashCode * 59 + this.Nyse.GetHashCode();
                if (this.Nasdaq != null)
                    hashCode = hashCode * 59 + this.Nasdaq.GetHashCode();
                if (this.Otc != null)
                    hashCode = hashCode * 59 + this.Otc.GetHashCode();
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
