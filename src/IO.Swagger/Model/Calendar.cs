/* 
 * WorkTracker v1
 *
 * WorkTracker API
 *
 * OpenAPI spec version: v1
 * Contact: desarrollo@worktracker.com
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Calendar
    /// </summary>
    [DataContract]
        public partial class Calendar :  IEquatable<Calendar>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Calendar" /> class.
        /// </summary>
        /// <param name="idCalendar">idCalendar.</param>
        /// <param name="day">day.</param>
        /// <param name="month">month.</param>
        /// <param name="year">year.</param>
        /// <param name="festive">festive.</param>
        public Calendar(int? idCalendar = default(int?), int? day = default(int?), int? month = default(int?), int? year = default(int?), bool? festive = default(bool?))
        {
            this.IdCalendar = idCalendar;
            this.Day = day;
            this.Month = month;
            this.Year = year;
            this.Festive = festive;
        }
        
        /// <summary>
        /// Gets or Sets IdCalendar
        /// </summary>
        [DataMember(Name="idCalendar", EmitDefaultValue=false)]
        public int? IdCalendar { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public int? Day { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public int? Month { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets Festive
        /// </summary>
        [DataMember(Name="festive", EmitDefaultValue=false)]
        public bool? Festive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Calendar {\n");
            sb.Append("  IdCalendar: ").Append(IdCalendar).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Festive: ").Append(Festive).Append("\n");
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
            return this.Equals(input as Calendar);
        }

        /// <summary>
        /// Returns true if Calendar instances are equal
        /// </summary>
        /// <param name="input">Instance of Calendar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Calendar input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdCalendar == input.IdCalendar ||
                    (this.IdCalendar != null &&
                    this.IdCalendar.Equals(input.IdCalendar))
                ) && 
                (
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
                ) && 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Festive == input.Festive ||
                    (this.Festive != null &&
                    this.Festive.Equals(input.Festive))
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
                if (this.IdCalendar != null)
                    hashCode = hashCode * 59 + this.IdCalendar.GetHashCode();
                if (this.Day != null)
                    hashCode = hashCode * 59 + this.Day.GetHashCode();
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Festive != null)
                    hashCode = hashCode * 59 + this.Festive.GetHashCode();
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