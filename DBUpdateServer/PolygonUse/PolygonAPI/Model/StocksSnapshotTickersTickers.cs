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
    /// StocksSnapshotTickersTickers
    /// </summary>
    [DataContract]
        public partial class StocksSnapshotTickersTickers :  IEquatable<StocksSnapshotTickersTickers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StocksSnapshotTickersTickers" /> class.
        /// </summary>
        /// <param name="day">day.</param>
        /// <param name="lastQuote">lastQuote.</param>
        /// <param name="lastTrade">lastTrade.</param>
        /// <param name="min">min.</param>
        /// <param name="prevDay">prevDay.</param>
        /// <param name="ticker">The exchange symbol that this item is traded under..</param>
        /// <param name="todaysChange">The value of the change the from previous day..</param>
        /// <param name="todaysChangePerc">The percentage change since the previous day..</param>
        /// <param name="updated">The last updated timestamp..</param>
        public StocksSnapshotTickersTickers(StocksSnapshotTickersDay day = default, StocksSnapshotTickersLastQuote lastQuote = default, StocksSnapshotTickersLastTrade lastTrade = default, StocksSnapshotTickersMin min = default(StocksSnapshotTickersMin), StocksSnapshotTickersDay prevDay = default, string ticker = default(string), double? todaysChange = default(double?), double? todaysChangePerc = default(double?), long? updated = default)
        {
            this.Day = day;
            this.LastQuote = lastQuote;
            this.LastTrade = lastTrade;
            this.Min = min;
            this.PrevDay = prevDay;
            this.Ticker = ticker;
            this.TodaysChange = todaysChange;
            this.TodaysChangePerc = todaysChangePerc;
            this.Updated = updated;
        }
        
        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public StocksSnapshotTickersDay Day { get; set; }

        /// <summary>
        /// Gets or Sets LastQuote
        /// </summary>
        [DataMember(Name="lastQuote", EmitDefaultValue=false)]
        public StocksSnapshotTickersLastQuote LastQuote { get; set; }

        /// <summary>
        /// Gets or Sets LastTrade
        /// </summary>
        [DataMember(Name="lastTrade", EmitDefaultValue=false)]
        public StocksSnapshotTickersLastTrade LastTrade { get; set; }

        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public StocksSnapshotTickersMin Min { get; set; }

        /// <summary>
        /// Gets or Sets PrevDay
        /// </summary>
        [DataMember(Name="prevDay", EmitDefaultValue=false)]
        public StocksSnapshotTickersDay PrevDay { get; set; }

        /// <summary>
        /// The exchange symbol that this item is traded under.
        /// </summary>
        /// <value>The exchange symbol that this item is traded under.</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The value of the change the from previous day.
        /// </summary>
        /// <value>The value of the change the from previous day.</value>
        [DataMember(Name="todaysChange", EmitDefaultValue=false)]
        public double? TodaysChange { get; set; }

        /// <summary>
        /// The percentage change since the previous day.
        /// </summary>
        /// <value>The percentage change since the previous day.</value>
        [DataMember(Name="todaysChangePerc", EmitDefaultValue=false)]
        public double? TodaysChangePerc { get; set; }

        /// <summary>
        /// The last updated timestamp.
        /// </summary>
        /// <value>The last updated timestamp.</value>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public long? Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StocksSnapshotTickersTickers {\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  LastQuote: ").Append(LastQuote).Append("\n");
            sb.Append("  LastTrade: ").Append(LastTrade).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  PrevDay: ").Append(PrevDay).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  TodaysChange: ").Append(TodaysChange).Append("\n");
            sb.Append("  TodaysChangePerc: ").Append(TodaysChangePerc).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
            return this.Equals(input as StocksSnapshotTickersTickers);
        }

        /// <summary>
        /// Returns true if StocksSnapshotTickersTickers instances are equal
        /// </summary>
        /// <param name="input">Instance of StocksSnapshotTickersTickers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StocksSnapshotTickersTickers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
                ) && 
                (
                    this.LastQuote == input.LastQuote ||
                    (this.LastQuote != null &&
                    this.LastQuote.Equals(input.LastQuote))
                ) && 
                (
                    this.LastTrade == input.LastTrade ||
                    (this.LastTrade != null &&
                    this.LastTrade.Equals(input.LastTrade))
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.PrevDay == input.PrevDay ||
                    (this.PrevDay != null &&
                    this.PrevDay.Equals(input.PrevDay))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.TodaysChange == input.TodaysChange ||
                    (this.TodaysChange != null &&
                    this.TodaysChange.Equals(input.TodaysChange))
                ) && 
                (
                    this.TodaysChangePerc == input.TodaysChangePerc ||
                    (this.TodaysChangePerc != null &&
                    this.TodaysChangePerc.Equals(input.TodaysChangePerc))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
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
                if (this.Day != null)
                    hashCode = hashCode * 59 + this.Day.GetHashCode();
                if (this.LastQuote != null)
                    hashCode = hashCode * 59 + this.LastQuote.GetHashCode();
                if (this.LastTrade != null)
                    hashCode = hashCode * 59 + this.LastTrade.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.PrevDay != null)
                    hashCode = hashCode * 59 + this.PrevDay.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.TodaysChange != null)
                    hashCode = hashCode * 59 + this.TodaysChange.GetHashCode();
                if (this.TodaysChangePerc != null)
                    hashCode = hashCode * 59 + this.TodaysChangePerc.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
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
