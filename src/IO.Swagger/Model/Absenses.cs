/* 
 * WorkTracker v1
 *
 * WorkTracker API
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Absenses
    /// </summary>
    [DataContract]
        public partial class Absenses :  IEquatable<Absenses>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Absenses" /> class.
        /// </summary>
        /// <param name="idAbsenses">idAbsenses.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="finishDate">finishDate.</param>
        /// <param name="status">status.</param>
        /// <param name="userId">userId.</param>
        /// <param name="absensesTypeId">absensesTypeId.</param>
        public Absenses(int? idAbsenses = default(int?), DateTime? startDate = default(DateTime?), DateTime? finishDate = default(DateTime?), bool? status = default(bool?), int? userId = default(int?), int? absensesTypeId = default(int?))
        {
            this.IdAbsenses = idAbsenses;
            this.StartDate = startDate;
            this.FinishDate = finishDate;
            this.Status = status;
            this.UserId = userId;
            this.AbsensesTypeId = absensesTypeId;
        }
        
        /// <summary>
        /// Gets or Sets IdAbsenses
        /// </summary>
        [DataMember(Name="idAbsenses", EmitDefaultValue=false)]
        public int? IdAbsenses { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets FinishDate
        /// </summary>
        [DataMember(Name="finishDate", EmitDefaultValue=false)]
        public DateTime? FinishDate { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public bool? Status { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets AbsensesTypeId
        /// </summary>
        [DataMember(Name="absensesTypeId", EmitDefaultValue=false)]
        public int? AbsensesTypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Absenses {\n");
            sb.Append("  IdAbsenses: ").Append(IdAbsenses).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  FinishDate: ").Append(FinishDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AbsensesTypeId: ").Append(AbsensesTypeId).Append("\n");
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
            return this.Equals(input as Absenses);
        }

        /// <summary>
        /// Returns true if Absenses instances are equal
        /// </summary>
        /// <param name="input">Instance of Absenses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Absenses input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdAbsenses == input.IdAbsenses ||
                    (this.IdAbsenses != null &&
                    this.IdAbsenses.Equals(input.IdAbsenses))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.FinishDate == input.FinishDate ||
                    (this.FinishDate != null &&
                    this.FinishDate.Equals(input.FinishDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.AbsensesTypeId == input.AbsensesTypeId ||
                    (this.AbsensesTypeId != null &&
                    this.AbsensesTypeId.Equals(input.AbsensesTypeId))
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
                if (this.IdAbsenses != null)
                    hashCode = hashCode * 59 + this.IdAbsenses.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.FinishDate != null)
                    hashCode = hashCode * 59 + this.FinishDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.AbsensesTypeId != null)
                    hashCode = hashCode * 59 + this.AbsensesTypeId.GetHashCode();
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