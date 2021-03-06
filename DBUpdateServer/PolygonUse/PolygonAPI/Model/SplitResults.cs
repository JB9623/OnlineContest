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
    /// SplitResults
    /// </summary>
    [DataContract]
        public partial class SplitResults :  IEquatable<SplitResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitResults" /> class.
        /// </summary>
        /// <param name="ticker">The exchange symbol that this item is traded under..</param>
        /// <param name="exDate">The execution date of the stock split..</param>
        /// <param name="paymentDate">The payment date of the stock split..</param>
        /// <param name="declaredDate">The declared date of the stock split..</param>
        /// <param name="ratio">This referst to the split ratio.  The split ratio is an inverse of the number of shares that a holder of the stock would have after the split divided by the number of shares that the holder had before.  For example: A split ratio of .5 means a 2 for 1 split. .</param>
        /// <param name="tofactor">The \&quot;to\&quot; factor of the split. This is used to calculate the split ratio forfactor/tofactor &#x3D; ratio (eg ½ &#x3D; 0.5). .</param>
        /// <param name="forfactor">The \&quot;for\&quot; factor of the split. This is used to calculate the split ratio forfactor/tofactor &#x3D; ratio (eg ½ &#x3D; 0.5). .</param>
        public SplitResults(string ticker = default(string), DateTime? exDate = default(DateTime?), DateTime? paymentDate = default(DateTime?), DateTime? declaredDate = default(DateTime?), double? ratio = default(double?), int? tofactor = default(int?), int? forfactor = default(int?))
        {
            this.Ticker = ticker;
            this.ExDate = exDate;
            this.PaymentDate = paymentDate;
            this.DeclaredDate = declaredDate;
            this.Ratio = ratio;
            this.Tofactor = tofactor;
            this.Forfactor = forfactor;
        }
        
        /// <summary>
        /// The exchange symbol that this item is traded under.
        /// </summary>
        /// <value>The exchange symbol that this item is traded under.</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The execution date of the stock split.
        /// </summary>
        /// <value>The execution date of the stock split.</value>
        [DataMember(Name="exDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ExDate { get; set; }

        /// <summary>
        /// The payment date of the stock split.
        /// </summary>
        /// <value>The payment date of the stock split.</value>
        [DataMember(Name="paymentDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// The declared date of the stock split.
        /// </summary>
        /// <value>The declared date of the stock split.</value>
        [DataMember(Name="declaredDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DeclaredDate { get; set; }

        /// <summary>
        /// This referst to the split ratio.  The split ratio is an inverse of the number of shares that a holder of the stock would have after the split divided by the number of shares that the holder had before.  For example: A split ratio of .5 means a 2 for 1 split. 
        /// </summary>
        /// <value>This referst to the split ratio.  The split ratio is an inverse of the number of shares that a holder of the stock would have after the split divided by the number of shares that the holder had before.  For example: A split ratio of .5 means a 2 for 1 split. </value>
        [DataMember(Name="ratio", EmitDefaultValue=false)]
        public double? Ratio { get; set; }

        /// <summary>
        /// The \&quot;to\&quot; factor of the split. This is used to calculate the split ratio forfactor/tofactor &#x3D; ratio (eg ½ &#x3D; 0.5). 
        /// </summary>
        /// <value>The \&quot;to\&quot; factor of the split. This is used to calculate the split ratio forfactor/tofactor &#x3D; ratio (eg ½ &#x3D; 0.5). </value>
        [DataMember(Name="tofactor", EmitDefaultValue=false)]
        public int? Tofactor { get; set; }

        /// <summary>
        /// The \&quot;for\&quot; factor of the split. This is used to calculate the split ratio forfactor/tofactor &#x3D; ratio (eg ½ &#x3D; 0.5). 
        /// </summary>
        /// <value>The \&quot;for\&quot; factor of the split. This is used to calculate the split ratio forfactor/tofactor &#x3D; ratio (eg ½ &#x3D; 0.5). </value>
        [DataMember(Name="forfactor", EmitDefaultValue=false)]
        public int? Forfactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SplitResults {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  ExDate: ").Append(ExDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  DeclaredDate: ").Append(DeclaredDate).Append("\n");
            sb.Append("  Ratio: ").Append(Ratio).Append("\n");
            sb.Append("  Tofactor: ").Append(Tofactor).Append("\n");
            sb.Append("  Forfactor: ").Append(Forfactor).Append("\n");
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
            return this.Equals(input as SplitResults);
        }

        /// <summary>
        /// Returns true if SplitResults instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitResults input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.ExDate == input.ExDate ||
                    (this.ExDate != null &&
                    this.ExDate.Equals(input.ExDate))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.DeclaredDate == input.DeclaredDate ||
                    (this.DeclaredDate != null &&
                    this.DeclaredDate.Equals(input.DeclaredDate))
                ) && 
                (
                    this.Ratio == input.Ratio ||
                    (this.Ratio != null &&
                    this.Ratio.Equals(input.Ratio))
                ) && 
                (
                    this.Tofactor == input.Tofactor ||
                    (this.Tofactor != null &&
                    this.Tofactor.Equals(input.Tofactor))
                ) && 
                (
                    this.Forfactor == input.Forfactor ||
                    (this.Forfactor != null &&
                    this.Forfactor.Equals(input.Forfactor))
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
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.ExDate != null)
                    hashCode = hashCode * 59 + this.ExDate.GetHashCode();
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
                if (this.DeclaredDate != null)
                    hashCode = hashCode * 59 + this.DeclaredDate.GetHashCode();
                if (this.Ratio != null)
                    hashCode = hashCode * 59 + this.Ratio.GetHashCode();
                if (this.Tofactor != null)
                    hashCode = hashCode * 59 + this.Tofactor.GetHashCode();
                if (this.Forfactor != null)
                    hashCode = hashCode * 59 + this.Forfactor.GetHashCode();
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
