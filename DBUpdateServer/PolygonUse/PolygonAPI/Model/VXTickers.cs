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
    /// VXTickers
    /// </summary>
    [DataContract]
        public partial class VXTickers :  IEquatable<VXTickers>, IValidatableObject
    {
        /// <summary>
        /// The market type of the asset.
        /// </summary>
        /// <value>The market type of the asset.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum MarketEnum
        {
            /// <summary>
            /// Enum Stocks for value: stocks
            /// </summary>
            [EnumMember(Value = "stocks")]
            Stocks = 1        }
        /// <summary>
        /// The market type of the asset.
        /// </summary>
        /// <value>The market type of the asset.</value>
        [DataMember(Name="market", EmitDefaultValue=false)]
        public MarketEnum? Market { get; set; }
        /// <summary>
        /// The locale of the asset.
        /// </summary>
        /// <value>The locale of the asset.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LocaleEnum
        {
            /// <summary>
            /// Enum Us for value: us
            /// </summary>
            [EnumMember(Value = "us")]
            Us = 1        }
        /// <summary>
        /// The locale of the asset.
        /// </summary>
        /// <value>The locale of the asset.</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public LocaleEnum? Locale { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VXTickers" /> class.
        /// </summary>
        /// <param name="ticker">The exchange symbol that this item is traded under. (required).</param>
        /// <param name="name">The name of the asset..</param>
        /// <param name="market">The market type of the asset..</param>
        /// <param name="locale">The locale of the asset..</param>
        /// <param name="primaryExchange">The ISO code of the primary listing exchange for this asset..</param>
        /// <param name="type">The type of the asset. Find the types that we support via our [Ticker Types API](https://polygon.io/docs/get_v2_reference_types_anchor)..</param>
        /// <param name="active">Whether or not the asset is actively traded. False means the asset has been delisted..</param>
        /// <param name="currencyName">The name of the currency that this asset is traded with..</param>
        /// <param name="cik">The CIK number for this ticker. Find more information [here](https://en.wikipedia.org/wiki/Central_Index_Key)..</param>
        /// <param name="compositeFigi">The composite OpenFIGI number for this ticker. Find more information [here](https://www.openfigi.com/).</param>
        /// <param name="shareClassFigi">The share Class OpenFIGI number for this ticker. Find more information [here](https://www.openfigi.com/).</param>
        /// <param name="lastUpdatedUtc">The last time this asset record was updated..</param>
        /// <param name="delistedUtc">The last date that the asset was traded..</param>
        public VXTickers(string ticker = default(string), string name = default(string), MarketEnum? market = default(MarketEnum?), LocaleEnum? locale = default(LocaleEnum?), string primaryExchange = default(string), string type = default(string), bool? active = default(bool?), string currencyName = default(string), string cik = default(string), string compositeFigi = default(string), string shareClassFigi = default(string), int? lastUpdatedUtc = default(int?), DateTime? delistedUtc = default(DateTime?))
        {
            // to ensure "ticker" is required (not null)
            if (ticker == null)
            {
                throw new InvalidDataException("ticker is a required property for VXTickers and cannot be null");
            }
            else
            {
                this.Ticker = ticker;
            }
            this.Name = name;
            this.Market = market;
            this.Locale = locale;
            this.PrimaryExchange = primaryExchange;
            this.Type = type;
            this.Active = active;
            this.CurrencyName = currencyName;
            this.Cik = cik;
            this.CompositeFigi = compositeFigi;
            this.ShareClassFigi = shareClassFigi;
            this.LastUpdatedUtc = lastUpdatedUtc;
            this.DelistedUtc = delistedUtc;
        }
        
        /// <summary>
        /// The exchange symbol that this item is traded under.
        /// </summary>
        /// <value>The exchange symbol that this item is traded under.</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The name of the asset.
        /// </summary>
        /// <value>The name of the asset.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The ISO code of the primary listing exchange for this asset.
        /// </summary>
        /// <value>The ISO code of the primary listing exchange for this asset.</value>
        [DataMember(Name="primary_exchange", EmitDefaultValue=false)]
        public string PrimaryExchange { get; set; }

        /// <summary>
        /// The type of the asset. Find the types that we support via our [Ticker Types API](https://polygon.io/docs/get_v2_reference_types_anchor).
        /// </summary>
        /// <value>The type of the asset. Find the types that we support via our [Ticker Types API](https://polygon.io/docs/get_v2_reference_types_anchor).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Whether or not the asset is actively traded. False means the asset has been delisted.
        /// </summary>
        /// <value>Whether or not the asset is actively traded. False means the asset has been delisted.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// The name of the currency that this asset is traded with.
        /// </summary>
        /// <value>The name of the currency that this asset is traded with.</value>
        [DataMember(Name="currency_name", EmitDefaultValue=false)]
        public string CurrencyName { get; set; }

        /// <summary>
        /// The CIK number for this ticker. Find more information [here](https://en.wikipedia.org/wiki/Central_Index_Key).
        /// </summary>
        /// <value>The CIK number for this ticker. Find more information [here](https://en.wikipedia.org/wiki/Central_Index_Key).</value>
        [DataMember(Name="cik", EmitDefaultValue=false)]
        public string Cik { get; set; }

        /// <summary>
        /// The composite OpenFIGI number for this ticker. Find more information [here](https://www.openfigi.com/)
        /// </summary>
        /// <value>The composite OpenFIGI number for this ticker. Find more information [here](https://www.openfigi.com/)</value>
        [DataMember(Name="composite_figi", EmitDefaultValue=false)]
        public string CompositeFigi { get; set; }

        /// <summary>
        /// The share Class OpenFIGI number for this ticker. Find more information [here](https://www.openfigi.com/)
        /// </summary>
        /// <value>The share Class OpenFIGI number for this ticker. Find more information [here](https://www.openfigi.com/)</value>
        [DataMember(Name="share_class_figi", EmitDefaultValue=false)]
        public string ShareClassFigi { get; set; }

        /// <summary>
        /// The last time this asset record was updated.
        /// </summary>
        /// <value>The last time this asset record was updated.</value>
        [DataMember(Name="last_updated_utc", EmitDefaultValue=false)]
        public int? LastUpdatedUtc { get; set; }

        /// <summary>
        /// The last date that the asset was traded.
        /// </summary>
        /// <value>The last date that the asset was traded.</value>
        [DataMember(Name="delisted_utc", EmitDefaultValue=false)]
        public DateTime? DelistedUtc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VXTickers {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  PrimaryExchange: ").Append(PrimaryExchange).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CurrencyName: ").Append(CurrencyName).Append("\n");
            sb.Append("  Cik: ").Append(Cik).Append("\n");
            sb.Append("  CompositeFigi: ").Append(CompositeFigi).Append("\n");
            sb.Append("  ShareClassFigi: ").Append(ShareClassFigi).Append("\n");
            sb.Append("  LastUpdatedUtc: ").Append(LastUpdatedUtc).Append("\n");
            sb.Append("  DelistedUtc: ").Append(DelistedUtc).Append("\n");
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
            return this.Equals(input as VXTickers);
        }

        /// <summary>
        /// Returns true if VXTickers instances are equal
        /// </summary>
        /// <param name="input">Instance of VXTickers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VXTickers input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Market == input.Market ||
                    (this.Market != null &&
                    this.Market.Equals(input.Market))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.PrimaryExchange == input.PrimaryExchange ||
                    (this.PrimaryExchange != null &&
                    this.PrimaryExchange.Equals(input.PrimaryExchange))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.CurrencyName == input.CurrencyName ||
                    (this.CurrencyName != null &&
                    this.CurrencyName.Equals(input.CurrencyName))
                ) && 
                (
                    this.Cik == input.Cik ||
                    (this.Cik != null &&
                    this.Cik.Equals(input.Cik))
                ) && 
                (
                    this.CompositeFigi == input.CompositeFigi ||
                    (this.CompositeFigi != null &&
                    this.CompositeFigi.Equals(input.CompositeFigi))
                ) && 
                (
                    this.ShareClassFigi == input.ShareClassFigi ||
                    (this.ShareClassFigi != null &&
                    this.ShareClassFigi.Equals(input.ShareClassFigi))
                ) && 
                (
                    this.LastUpdatedUtc == input.LastUpdatedUtc ||
                    (this.LastUpdatedUtc != null &&
                    this.LastUpdatedUtc.Equals(input.LastUpdatedUtc))
                ) && 
                (
                    this.DelistedUtc == input.DelistedUtc ||
                    (this.DelistedUtc != null &&
                    this.DelistedUtc.Equals(input.DelistedUtc))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Market != null)
                    hashCode = hashCode * 59 + this.Market.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.PrimaryExchange != null)
                    hashCode = hashCode * 59 + this.PrimaryExchange.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.CurrencyName != null)
                    hashCode = hashCode * 59 + this.CurrencyName.GetHashCode();
                if (this.Cik != null)
                    hashCode = hashCode * 59 + this.Cik.GetHashCode();
                if (this.CompositeFigi != null)
                    hashCode = hashCode * 59 + this.CompositeFigi.GetHashCode();
                if (this.ShareClassFigi != null)
                    hashCode = hashCode * 59 + this.ShareClassFigi.GetHashCode();
                if (this.LastUpdatedUtc != null)
                    hashCode = hashCode * 59 + this.LastUpdatedUtc.GetHashCode();
                if (this.DelistedUtc != null)
                    hashCode = hashCode * 59 + this.DelistedUtc.GetHashCode();
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
