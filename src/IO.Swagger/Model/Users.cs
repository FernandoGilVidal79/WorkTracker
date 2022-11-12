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
    /// Users
    /// </summary>
    [DataContract]
        public partial class Users :  IEquatable<Users>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Users" /> class.
        /// </summary>
        /// <param name="idUser">idUser.</param>
        /// <param name="userName">userName.</param>
        /// <param name="surName1">surName1.</param>
        /// <param name="surName2">surName2.</param>
        /// <param name="email">email.</param>
        /// <param name="phone">phone.</param>
        /// <param name="department">department.</param>
        /// <param name="status">status.</param>
        /// <param name="userTypeId">userTypeId.</param>
        /// <param name="password">password.</param>
        /// <param name="nHollidays">nHollidays.</param>
        public Users(int? idUser = default(int?), string userName = default(string), string surName1 = default(string), string surName2 = default(string), string email = default(string), int? phone = default(int?), string department = default(string), bool? status = default(bool?), int? userTypeId = default(int?), string password = default(string), int? nHollidays = default(int?))
        {
            this.IdUser = idUser;
            this.UserName = userName;
            this.SurName1 = surName1;
            this.SurName2 = surName2;
            this.Email = email;
            this.Phone = phone;
            this.Department = department;
            this.Status = status;
            this.UserTypeId = userTypeId;
            this.Password = password;
            this.NHollidays = nHollidays;
        }
        
        /// <summary>
        /// Gets or Sets IdUser
        /// </summary>
        [DataMember(Name="idUser", EmitDefaultValue=false)]
        public int? IdUser { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets SurName1
        /// </summary>
        [DataMember(Name="surName1", EmitDefaultValue=false)]
        public string SurName1 { get; set; }

        /// <summary>
        /// Gets or Sets SurName2
        /// </summary>
        [DataMember(Name="surName2", EmitDefaultValue=false)]
        public string SurName2 { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public int? Phone { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public bool? Status { get; set; }

        /// <summary>
        /// Gets or Sets UserTypeId
        /// </summary>
        [DataMember(Name="userTypeId", EmitDefaultValue=false)]
        public int? UserTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets NHollidays
        /// </summary>
        [DataMember(Name="nHollidays", EmitDefaultValue=false)]
        public int? NHollidays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Users {\n");
            sb.Append("  IdUser: ").Append(IdUser).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  SurName1: ").Append(SurName1).Append("\n");
            sb.Append("  SurName2: ").Append(SurName2).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserTypeId: ").Append(UserTypeId).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  NHollidays: ").Append(NHollidays).Append("\n");
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
            return this.Equals(input as Users);
        }

        /// <summary>
        /// Returns true if Users instances are equal
        /// </summary>
        /// <param name="input">Instance of Users to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Users input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdUser == input.IdUser ||
                    (this.IdUser != null &&
                    this.IdUser.Equals(input.IdUser))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.SurName1 == input.SurName1 ||
                    (this.SurName1 != null &&
                    this.SurName1.Equals(input.SurName1))
                ) && 
                (
                    this.SurName2 == input.SurName2 ||
                    (this.SurName2 != null &&
                    this.SurName2.Equals(input.SurName2))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UserTypeId == input.UserTypeId ||
                    (this.UserTypeId != null &&
                    this.UserTypeId.Equals(input.UserTypeId))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.NHollidays == input.NHollidays ||
                    (this.NHollidays != null &&
                    this.NHollidays.Equals(input.NHollidays))
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
                if (this.IdUser != null)
                    hashCode = hashCode * 59 + this.IdUser.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.SurName1 != null)
                    hashCode = hashCode * 59 + this.SurName1.GetHashCode();
                if (this.SurName2 != null)
                    hashCode = hashCode * 59 + this.SurName2.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UserTypeId != null)
                    hashCode = hashCode * 59 + this.UserTypeId.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.NHollidays != null)
                    hashCode = hashCode * 59 + this.NHollidays.GetHashCode();
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
