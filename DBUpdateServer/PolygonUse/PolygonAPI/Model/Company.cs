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
    /// Company
    /// </summary>
    [DataContract]
        public partial class Company :  IEquatable<Company>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="logo">The URL of the entity&#x27;s logo..</param>
        /// <param name="exchange">The symbol&#x27;s primary exchange..</param>
        /// <param name="exchangeSymbol">The exchange code (id) of the symbol&#x27;s primary exchange..</param>
        /// <param name="type">The type or class of the security.  (&lt;a alt&#x3D;\&quot;Full List of Ticker Types\&quot; href&#x3D;\&quot;https://polygon.io/docs/get_v2_reference_types_anchor\&quot;&gt;Full List of Ticker Types&lt;/a&gt;).</param>
        /// <param name="name">The name of the company/entity..</param>
        /// <param name="symbol">The exchange symbol that this item is traded under..</param>
        /// <param name="listdate">The date that the symbol was listed on the exchange..</param>
        /// <param name="cik">The official CIK guid used for SEC database/filings..</param>
        /// <param name="bloomberg">The Bloomberg guid for the symbol..</param>
        /// <param name="figi">The OpenFigi project guid for the symbol. (&lt;a rel&#x3D;\&quot;nofollow\&quot; target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://openfigi.com/\&quot;&gt;https://openfigi.com/&lt;/a&gt;).</param>
        /// <param name="lei">The Legal Entity Identifier (LEI) guid for the symbol. (&lt;a rel&#x3D;\&quot;nofollow\&quot; target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://en.wikipedia.org/wiki/Legal_Entity_Identifier\&quot;&gt;https://en.wikipedia.org/wiki/Legal_Entity_Identifier&lt;/a&gt;).</param>
        /// <param name="sic">Standard Industrial Classification (SIC) id for the symbol. (&lt;a rel&#x3D;\&quot;nofollow\&quot; target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://en.wikipedia.org/wiki/Standard_Industrial_Classification\&quot;&gt;https://en.wikipedia.org/wiki/Legal_Entity_Identifier&lt;/a&gt;).</param>
        /// <param name="country">The country in which the company is registered..</param>
        /// <param name="industry">The industry in which the company operates..</param>
        /// <param name="sector">The sector of the indsutry in which the symbol operates..</param>
        /// <param name="marketcap">The current market cap for the company..</param>
        /// <param name="employees">The approximate number of employees for the company..</param>
        /// <param name="phone">The phone number for the company. This is usually a corporate contact number..</param>
        /// <param name="ceo">The name of the company&#x27;s current CEO..</param>
        /// <param name="url">The URL of the company&#x27;s website.</param>
        /// <param name="description">A description of the company and what they do/offer..</param>
        /// <param name="hqAddress">The street address for the company&#x27;s headquarters..</param>
        /// <param name="hqState">The state in which the company&#x27;s headquarters is located..</param>
        /// <param name="hqCountry">The country in which the company&#x27;s headquarters is located..</param>
        /// <param name="similar">A list of ticker symbols for similar companies..</param>
        /// <param name="tags">tags.</param>
        /// <param name="updated">The last time this company record was updated..</param>
        /// <param name="active">Indicates if the security is actively listed.  If false, this means the company is no longer listed and cannot be traded..</param>
        public Company(string logo = default(string), string exchange = default(string), string exchangeSymbol = default(string), string type = default(string), string name = default(string), string symbol = default(string), DateTime? listdate = default(DateTime?), string cik = default(string), string bloomberg = default(string), string figi = default(string), string lei = default(string), int? sic = default(int?), string country = default(string), string industry = default(string), string sector = default(string), int? marketcap = default(int?), int? employees = default(int?), string phone = default(string), string ceo = default(string), string url = default(string), string description = default(string), string hqAddress = default(string), string hqState = default(string), string hqCountry = default(string), List<string> similar = default(List<string>), List<string> tags = default(List<string>), DateTime? updated = default(DateTime?), bool? active = default(bool?))
        {
            this.Logo = logo;
            this.Exchange = exchange;
            this.ExchangeSymbol = exchangeSymbol;
            this.Type = type;
            this.Name = name;
            this.Symbol = symbol;
            this.Listdate = listdate;
            this.Cik = cik;
            this.Bloomberg = bloomberg;
            this.Figi = figi;
            this.Lei = lei;
            this.Sic = sic;
            this.Country = country;
            this.Industry = industry;
            this.Sector = sector;
            this.Marketcap = marketcap;
            this.Employees = employees;
            this.Phone = phone;
            this.Ceo = ceo;
            this.Url = url;
            this.Description = description;
            this.HqAddress = hqAddress;
            this.HqState = hqState;
            this.HqCountry = hqCountry;
            this.Similar = similar;
            this.Tags = tags;
            this.Updated = updated;
            this.Active = active;
        }
        
        /// <summary>
        /// The URL of the entity&#x27;s logo.
        /// </summary>
        /// <value>The URL of the entity&#x27;s logo.</value>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// The symbol&#x27;s primary exchange.
        /// </summary>
        /// <value>The symbol&#x27;s primary exchange.</value>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public string Exchange { get; set; }

        /// <summary>
        /// The exchange code (id) of the symbol&#x27;s primary exchange.
        /// </summary>
        /// <value>The exchange code (id) of the symbol&#x27;s primary exchange.</value>
        [DataMember(Name="exchangeSymbol", EmitDefaultValue=false)]
        public string ExchangeSymbol { get; set; }

        /// <summary>
        /// The type or class of the security.  (&lt;a alt&#x3D;\&quot;Full List of Ticker Types\&quot; href&#x3D;\&quot;https://polygon.io/docs/get_v2_reference_types_anchor\&quot;&gt;Full List of Ticker Types&lt;/a&gt;)
        /// </summary>
        /// <value>The type or class of the security.  (&lt;a alt&#x3D;\&quot;Full List of Ticker Types\&quot; href&#x3D;\&quot;https://polygon.io/docs/get_v2_reference_types_anchor\&quot;&gt;Full List of Ticker Types&lt;/a&gt;)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The name of the company/entity.
        /// </summary>
        /// <value>The name of the company/entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The exchange symbol that this item is traded under.
        /// </summary>
        /// <value>The exchange symbol that this item is traded under.</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// The date that the symbol was listed on the exchange.
        /// </summary>
        /// <value>The date that the symbol was listed on the exchange.</value>
        [DataMember(Name="listdate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Listdate { get; set; }

        /// <summary>
        /// The official CIK guid used for SEC database/filings.
        /// </summary>
        /// <value>The official CIK guid used for SEC database/filings.</value>
        [DataMember(Name="cik", EmitDefaultValue=false)]
        public string Cik { get; set; }

        /// <summary>
        /// The Bloomberg guid for the symbol.
        /// </summary>
        /// <value>The Bloomberg guid for the symbol.</value>
        [DataMember(Name="bloomberg", EmitDefaultValue=false)]
        public string Bloomberg { get; set; }

        /// <summary>
        /// The OpenFigi project guid for the symbol. (&lt;a rel&#x3D;\&quot;nofollow\&quot; target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://openfigi.com/\&quot;&gt;https://openfigi.com/&lt;/a&gt;)
        /// </summary>
        /// <value>The OpenFigi project guid for the symbol. (&lt;a rel&#x3D;\&quot;nofollow\&quot; target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://openfigi.com/\&quot;&gt;https://openfigi.com/&lt;/a&gt;)</value>
        [DataMember(Name="figi", EmitDefaultValue=false)]
        public string Figi { get; set; }

        /// <summary>
        /// The Legal Entity Identifier (LEI) guid for the symbol. (&lt;a rel&#x3D;\&quot;nofollow\&quot; target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://en.wikipedia.org/wiki/Legal_Entity_Identifier\&quot;&gt;https://en.wikipedia.org/wiki/Legal_Entity_Identifier&lt;/a&gt;)
        /// </summary>
        /// <value>The Legal Entity Identifier (LEI) guid for the symbol. (&lt;a rel&#x3D;\&quot;nofollow\&quot; target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://en.wikipedia.org/wiki/Legal_Entity_Identifier\&quot;&gt;https://en.wikipedia.org/wiki/Legal_Entity_Identifier&lt;/a&gt;)</value>
        [DataMember(Name="lei", EmitDefaultValue=false)]
        public string Lei { get; set; }

        /// <summary>
        /// Standard Industrial Classification (SIC) id for the symbol. (&lt;a rel&#x3D;\&quot;nofollow\&quot; target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://en.wikipedia.org/wiki/Standard_Industrial_Classification\&quot;&gt;https://en.wikipedia.org/wiki/Legal_Entity_Identifier&lt;/a&gt;)
        /// </summary>
        /// <value>Standard Industrial Classification (SIC) id for the symbol. (&lt;a rel&#x3D;\&quot;nofollow\&quot; target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://en.wikipedia.org/wiki/Standard_Industrial_Classification\&quot;&gt;https://en.wikipedia.org/wiki/Legal_Entity_Identifier&lt;/a&gt;)</value>
        [DataMember(Name="sic", EmitDefaultValue=false)]
        public int? Sic { get; set; }

        /// <summary>
        /// The country in which the company is registered.
        /// </summary>
        /// <value>The country in which the company is registered.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// The industry in which the company operates.
        /// </summary>
        /// <value>The industry in which the company operates.</value>
        [DataMember(Name="industry", EmitDefaultValue=false)]
        public string Industry { get; set; }

        /// <summary>
        /// The sector of the indsutry in which the symbol operates.
        /// </summary>
        /// <value>The sector of the indsutry in which the symbol operates.</value>
        [DataMember(Name="sector", EmitDefaultValue=false)]
        public string Sector { get; set; }

        /// <summary>
        /// The current market cap for the company.
        /// </summary>
        /// <value>The current market cap for the company.</value>
        [DataMember(Name="marketcap", EmitDefaultValue=false)]
        public int? Marketcap { get; set; }

        /// <summary>
        /// The approximate number of employees for the company.
        /// </summary>
        /// <value>The approximate number of employees for the company.</value>
        [DataMember(Name="employees", EmitDefaultValue=false)]
        public int? Employees { get; set; }

        /// <summary>
        /// The phone number for the company. This is usually a corporate contact number.
        /// </summary>
        /// <value>The phone number for the company. This is usually a corporate contact number.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The name of the company&#x27;s current CEO.
        /// </summary>
        /// <value>The name of the company&#x27;s current CEO.</value>
        [DataMember(Name="ceo", EmitDefaultValue=false)]
        public string Ceo { get; set; }

        /// <summary>
        /// The URL of the company&#x27;s website
        /// </summary>
        /// <value>The URL of the company&#x27;s website</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// A description of the company and what they do/offer.
        /// </summary>
        /// <value>A description of the company and what they do/offer.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The street address for the company&#x27;s headquarters.
        /// </summary>
        /// <value>The street address for the company&#x27;s headquarters.</value>
        [DataMember(Name="hq_address", EmitDefaultValue=false)]
        public string HqAddress { get; set; }

        /// <summary>
        /// The state in which the company&#x27;s headquarters is located.
        /// </summary>
        /// <value>The state in which the company&#x27;s headquarters is located.</value>
        [DataMember(Name="hq_state", EmitDefaultValue=false)]
        public string HqState { get; set; }

        /// <summary>
        /// The country in which the company&#x27;s headquarters is located.
        /// </summary>
        /// <value>The country in which the company&#x27;s headquarters is located.</value>
        [DataMember(Name="hq_country", EmitDefaultValue=false)]
        public string HqCountry { get; set; }

        /// <summary>
        /// A list of ticker symbols for similar companies.
        /// </summary>
        /// <value>A list of ticker symbols for similar companies.</value>
        [DataMember(Name="similar", EmitDefaultValue=false)]
        public List<string> Similar { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The last time this company record was updated.
        /// </summary>
        /// <value>The last time this company record was updated.</value>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Indicates if the security is actively listed.  If false, this means the company is no longer listed and cannot be traded.
        /// </summary>
        /// <value>Indicates if the security is actively listed.  If false, this means the company is no longer listed and cannot be traded.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  ExchangeSymbol: ").Append(ExchangeSymbol).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Listdate: ").Append(Listdate).Append("\n");
            sb.Append("  Cik: ").Append(Cik).Append("\n");
            sb.Append("  Bloomberg: ").Append(Bloomberg).Append("\n");
            sb.Append("  Figi: ").Append(Figi).Append("\n");
            sb.Append("  Lei: ").Append(Lei).Append("\n");
            sb.Append("  Sic: ").Append(Sic).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  Sector: ").Append(Sector).Append("\n");
            sb.Append("  Marketcap: ").Append(Marketcap).Append("\n");
            sb.Append("  Employees: ").Append(Employees).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Ceo: ").Append(Ceo).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HqAddress: ").Append(HqAddress).Append("\n");
            sb.Append("  HqState: ").Append(HqState).Append("\n");
            sb.Append("  HqCountry: ").Append(HqCountry).Append("\n");
            sb.Append("  Similar: ").Append(Similar).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(input as Company);
        }

        /// <summary>
        /// Returns true if Company instances are equal
        /// </summary>
        /// <param name="input">Instance of Company to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Company input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.ExchangeSymbol == input.ExchangeSymbol ||
                    (this.ExchangeSymbol != null &&
                    this.ExchangeSymbol.Equals(input.ExchangeSymbol))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Listdate == input.Listdate ||
                    (this.Listdate != null &&
                    this.Listdate.Equals(input.Listdate))
                ) && 
                (
                    this.Cik == input.Cik ||
                    (this.Cik != null &&
                    this.Cik.Equals(input.Cik))
                ) && 
                (
                    this.Bloomberg == input.Bloomberg ||
                    (this.Bloomberg != null &&
                    this.Bloomberg.Equals(input.Bloomberg))
                ) && 
                (
                    this.Figi == input.Figi ||
                    (this.Figi != null &&
                    this.Figi.Equals(input.Figi))
                ) && 
                (
                    this.Lei == input.Lei ||
                    (this.Lei != null &&
                    this.Lei.Equals(input.Lei))
                ) && 
                (
                    this.Sic == input.Sic ||
                    (this.Sic != null &&
                    this.Sic.Equals(input.Sic))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.Sector == input.Sector ||
                    (this.Sector != null &&
                    this.Sector.Equals(input.Sector))
                ) && 
                (
                    this.Marketcap == input.Marketcap ||
                    (this.Marketcap != null &&
                    this.Marketcap.Equals(input.Marketcap))
                ) && 
                (
                    this.Employees == input.Employees ||
                    (this.Employees != null &&
                    this.Employees.Equals(input.Employees))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Ceo == input.Ceo ||
                    (this.Ceo != null &&
                    this.Ceo.Equals(input.Ceo))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HqAddress == input.HqAddress ||
                    (this.HqAddress != null &&
                    this.HqAddress.Equals(input.HqAddress))
                ) && 
                (
                    this.HqState == input.HqState ||
                    (this.HqState != null &&
                    this.HqState.Equals(input.HqState))
                ) && 
                (
                    this.HqCountry == input.HqCountry ||
                    (this.HqCountry != null &&
                    this.HqCountry.Equals(input.HqCountry))
                ) && 
                (
                    this.Similar == input.Similar ||
                    this.Similar != null &&
                    input.Similar != null &&
                    this.Similar.SequenceEqual(input.Similar)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
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
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.ExchangeSymbol != null)
                    hashCode = hashCode * 59 + this.ExchangeSymbol.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Listdate != null)
                    hashCode = hashCode * 59 + this.Listdate.GetHashCode();
                if (this.Cik != null)
                    hashCode = hashCode * 59 + this.Cik.GetHashCode();
                if (this.Bloomberg != null)
                    hashCode = hashCode * 59 + this.Bloomberg.GetHashCode();
                if (this.Figi != null)
                    hashCode = hashCode * 59 + this.Figi.GetHashCode();
                if (this.Lei != null)
                    hashCode = hashCode * 59 + this.Lei.GetHashCode();
                if (this.Sic != null)
                    hashCode = hashCode * 59 + this.Sic.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.Sector != null)
                    hashCode = hashCode * 59 + this.Sector.GetHashCode();
                if (this.Marketcap != null)
                    hashCode = hashCode * 59 + this.Marketcap.GetHashCode();
                if (this.Employees != null)
                    hashCode = hashCode * 59 + this.Employees.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Ceo != null)
                    hashCode = hashCode * 59 + this.Ceo.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HqAddress != null)
                    hashCode = hashCode * 59 + this.HqAddress.GetHashCode();
                if (this.HqState != null)
                    hashCode = hashCode * 59 + this.HqState.GetHashCode();
                if (this.HqCountry != null)
                    hashCode = hashCode * 59 + this.HqCountry.GetHashCode();
                if (this.Similar != null)
                    hashCode = hashCode * 59 + this.Similar.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
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
