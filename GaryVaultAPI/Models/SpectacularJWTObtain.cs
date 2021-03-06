/*
 * Nordigen Account Information Services API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0 (v2)
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Obtain new JWT pair.
    /// </summary>
    [DataContract(Name = "SpectacularJWTObtain")]
    public partial class SpectacularJWTObtain : IEquatable<SpectacularJWTObtain>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpectacularJWTObtain" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpectacularJWTObtain() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpectacularJWTObtain" /> class.
        /// </summary>
        /// <param name="password">password (required).</param>
        public SpectacularJWTObtain(string password = default(string))
        {
            // to ensure "password" is required (not null)
            if (password == null) {
                throw new ArgumentNullException("password is a required property for SpectacularJWTObtain and cannot be null");
            }
            this.Password = password;
        }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Your access token
        /// </summary>
        /// <value>Your access token</value>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public string Access { get; private set; }

        /// <summary>
        /// Returns false as Access should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccess()
        {
            return false;
        }
        /// <summary>
        /// Access token expires in seconds
        /// </summary>
        /// <value>Access token expires in seconds</value>
        [DataMember(Name = "access_expires", EmitDefaultValue = false)]
        public int AccessExpires { get; private set; }

        /// <summary>
        /// Returns false as AccessExpires should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccessExpires()
        {
            return false;
        }
        /// <summary>
        /// Your refresh token
        /// </summary>
        /// <value>Your refresh token</value>
        [DataMember(Name = "refresh", EmitDefaultValue = false)]
        public string Refresh { get; private set; }

        /// <summary>
        /// Returns false as Refresh should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRefresh()
        {
            return false;
        }
        /// <summary>
        /// Refresh token expires in seconds
        /// </summary>
        /// <value>Refresh token expires in seconds</value>
        [DataMember(Name = "refresh_expires", EmitDefaultValue = false)]
        public int RefreshExpires { get; private set; }

        /// <summary>
        /// Returns false as RefreshExpires should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRefreshExpires()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpectacularJWTObtain {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  AccessExpires: ").Append(AccessExpires).Append("\n");
            sb.Append("  Refresh: ").Append(Refresh).Append("\n");
            sb.Append("  RefreshExpires: ").Append(RefreshExpires).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpectacularJWTObtain);
        }

        /// <summary>
        /// Returns true if SpectacularJWTObtain instances are equal
        /// </summary>
        /// <param name="input">Instance of SpectacularJWTObtain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpectacularJWTObtain input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
                ) && 
                (
                    this.AccessExpires == input.AccessExpires ||
                    this.AccessExpires.Equals(input.AccessExpires)
                ) && 
                (
                    this.Refresh == input.Refresh ||
                    (this.Refresh != null &&
                    this.Refresh.Equals(input.Refresh))
                ) && 
                (
                    this.RefreshExpires == input.RefreshExpires ||
                    this.RefreshExpires.Equals(input.RefreshExpires)
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
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Access != null)
                {
                    hashCode = (hashCode * 59) + this.Access.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccessExpires.GetHashCode();
                if (this.Refresh != null)
                {
                    hashCode = (hashCode * 59) + this.Refresh.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RefreshExpires.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
