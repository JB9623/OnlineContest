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
    /// TickerTypesResultsIndexTypes
    /// </summary>
    [DataContract]
        public partial class TickerTypesResultsIndexTypes :  IEquatable<TickerTypesResultsIndexTypes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TickerTypesResultsIndexTypes" /> class.
        /// </summary>
        /// <param name="iNDEX">Index.</param>
        /// <param name="eTF">Exchange Traded Fund (ETF).</param>
        /// <param name="eTN">Exchange Traded Note (ETN).</param>
        /// <param name="eTMF">Exchange Traded Managed Fund (ETMF).</param>
        /// <param name="sETTLEMENT">Settlement.</param>
        /// <param name="sPOT">Spot.</param>
        /// <param name="sUBPROD">Subordinated product.</param>
        /// <param name="wC">World Currency.</param>
        /// <param name="aLPHAINDEX">Alpha Index.</param>
        public TickerTypesResultsIndexTypes(string iNDEX = default(string), string eTF = default(string), string eTN = default(string), string eTMF = default(string), string sETTLEMENT = default(string), string sPOT = default(string), string sUBPROD = default(string), string wC = default(string), string aLPHAINDEX = default(string))
        {
            this.INDEX = iNDEX;
            this.ETF = eTF;
            this.ETN = eTN;
            this.ETMF = eTMF;
            this.SETTLEMENT = sETTLEMENT;
            this.SPOT = sPOT;
            this.SUBPROD = sUBPROD;
            this.WC = wC;
            this.ALPHAINDEX = aLPHAINDEX;
        }
        
        /// <summary>
        /// Index
        /// </summary>
        /// <value>Index</value>
        [DataMember(Name="INDEX", EmitDefaultValue=false)]
        public string INDEX { get; set; }

        /// <summary>
        /// Exchange Traded Fund (ETF)
        /// </summary>
        /// <value>Exchange Traded Fund (ETF)</value>
        [DataMember(Name="ETF", EmitDefaultValue=false)]
        public string ETF { get; set; }

        /// <summary>
        /// Exchange Traded Note (ETN)
        /// </summary>
        /// <value>Exchange Traded Note (ETN)</value>
        [DataMember(Name="ETN", EmitDefaultValue=false)]
        public string ETN { get; set; }

        /// <summary>
        /// Exchange Traded Managed Fund (ETMF)
        /// </summary>
        /// <value>Exchange Traded Managed Fund (ETMF)</value>
        [DataMember(Name="ETMF", EmitDefaultValue=false)]
        public string ETMF { get; set; }

        /// <summary>
        /// Settlement
        /// </summary>
        /// <value>Settlement</value>
        [DataMember(Name="SETTLEMENT", EmitDefaultValue=false)]
        public string SETTLEMENT { get; set; }

        /// <summary>
        /// Spot
        /// </summary>
        /// <value>Spot</value>
        [DataMember(Name="SPOT", EmitDefaultValue=false)]
        public string SPOT { get; set; }

        /// <summary>
        /// Subordinated product
        /// </summary>
        /// <value>Subordinated product</value>
        [DataMember(Name="SUBPROD", EmitDefaultValue=false)]
        public string SUBPROD { get; set; }

        /// <summary>
        /// World Currency
        /// </summary>
        /// <value>World Currency</value>
        [DataMember(Name="WC", EmitDefaultValue=false)]
        public string WC { get; set; }

        /// <summary>
        /// Alpha Index
        /// </summary>
        /// <value>Alpha Index</value>
        [DataMember(Name="ALPHAINDEX", EmitDefaultValue=false)]
        public string ALPHAINDEX { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TickerTypesResultsIndexTypes {\n");
            sb.Append("  INDEX: ").Append(INDEX).Append("\n");
            sb.Append("  ETF: ").Append(ETF).Append("\n");
            sb.Append("  ETN: ").Append(ETN).Append("\n");
            sb.Append("  ETMF: ").Append(ETMF).Append("\n");
            sb.Append("  SETTLEMENT: ").Append(SETTLEMENT).Append("\n");
            sb.Append("  SPOT: ").Append(SPOT).Append("\n");
            sb.Append("  SUBPROD: ").Append(SUBPROD).Append("\n");
            sb.Append("  WC: ").Append(WC).Append("\n");
            sb.Append("  ALPHAINDEX: ").Append(ALPHAINDEX).Append("\n");
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
            return this.Equals(input as TickerTypesResultsIndexTypes);
        }

        /// <summary>
        /// Returns true if TickerTypesResultsIndexTypes instances are equal
        /// </summary>
        /// <param name="input">Instance of TickerTypesResultsIndexTypes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TickerTypesResultsIndexTypes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.INDEX == input.INDEX ||
                    (this.INDEX != null &&
                    this.INDEX.Equals(input.INDEX))
                ) && 
                (
                    this.ETF == input.ETF ||
                    (this.ETF != null &&
                    this.ETF.Equals(input.ETF))
                ) && 
                (
                    this.ETN == input.ETN ||
                    (this.ETN != null &&
                    this.ETN.Equals(input.ETN))
                ) && 
                (
                    this.ETMF == input.ETMF ||
                    (this.ETMF != null &&
                    this.ETMF.Equals(input.ETMF))
                ) && 
                (
                    this.SETTLEMENT == input.SETTLEMENT ||
                    (this.SETTLEMENT != null &&
                    this.SETTLEMENT.Equals(input.SETTLEMENT))
                ) && 
                (
                    this.SPOT == input.SPOT ||
                    (this.SPOT != null &&
                    this.SPOT.Equals(input.SPOT))
                ) && 
                (
                    this.SUBPROD == input.SUBPROD ||
                    (this.SUBPROD != null &&
                    this.SUBPROD.Equals(input.SUBPROD))
                ) && 
                (
                    this.WC == input.WC ||
                    (this.WC != null &&
                    this.WC.Equals(input.WC))
                ) && 
                (
                    this.ALPHAINDEX == input.ALPHAINDEX ||
                    (this.ALPHAINDEX != null &&
                    this.ALPHAINDEX.Equals(input.ALPHAINDEX))
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
                if (this.INDEX != null)
                    hashCode = hashCode * 59 + this.INDEX.GetHashCode();
                if (this.ETF != null)
                    hashCode = hashCode * 59 + this.ETF.GetHashCode();
                if (this.ETN != null)
                    hashCode = hashCode * 59 + this.ETN.GetHashCode();
                if (this.ETMF != null)
                    hashCode = hashCode * 59 + this.ETMF.GetHashCode();
                if (this.SETTLEMENT != null)
                    hashCode = hashCode * 59 + this.SETTLEMENT.GetHashCode();
                if (this.SPOT != null)
                    hashCode = hashCode * 59 + this.SPOT.GetHashCode();
                if (this.SUBPROD != null)
                    hashCode = hashCode * 59 + this.SUBPROD.GetHashCode();
                if (this.WC != null)
                    hashCode = hashCode * 59 + this.WC.GetHashCode();
                if (this.ALPHAINDEX != null)
                    hashCode = hashCode * 59 + this.ALPHAINDEX.GetHashCode();
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
