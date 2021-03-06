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
    /// Obtain JWT pair.
    /// </summary>
    [DataContract(Name = "JWTObtainPair")]
    public partial class JWTObtainPair : IEquatable<JWTObtainPair>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JWTObtainPair" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JWTObtainPair() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JWTObtainPair" /> class.
        /// </summary>
        /// <param name="secretId">Secret id from /user-secrets/ (required).</param>
        /// <param name="secretKey">Secret key from /user-secrets/ (required).</param>
        public JWTObtainPair(string secretId = default(string), string secretKey = default(string))
        {
            // to ensure "secretId" is required (not null)
            if (secretId == null) {
                throw new ArgumentNullException("secretId is a required property for JWTObtainPair and cannot be null");
            }
            this.SecretId = secretId;
            // to ensure "secretKey" is required (not null)
            if (secretKey == null) {
                throw new ArgumentNullException("secretKey is a required property for JWTObtainPair and cannot be null");
            }
            this.SecretKey = secretKey;
        }

        /// <summary>
        /// Secret id from /user-secrets/
        /// </summary>
        /// <value>Secret id from /user-secrets/</value>
        [DataMember(Name = "secret_id", IsRequired = true, EmitDefaultValue = false)]
        public string SecretId { get; set; }

        /// <summary>
        /// Secret key from /user-secrets/
        /// </summary>
        /// <value>Secret key from /user-secrets/</value>
        [DataMember(Name = "secret_key", IsRequired = true, EmitDefaultValue = false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JWTObtainPair {\n");
            sb.Append("  SecretId: ").Append(SecretId).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
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
            return this.Equals(input as JWTObtainPair);
        }

        /// <summary>
        /// Returns true if JWTObtainPair instances are equal
        /// </summary>
        /// <param name="input">Instance of JWTObtainPair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JWTObtainPair input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SecretId == input.SecretId ||
                    (this.SecretId != null &&
                    this.SecretId.Equals(input.SecretId))
                ) && 
                (
                    this.SecretKey == input.SecretKey ||
                    (this.SecretKey != null &&
                    this.SecretKey.Equals(input.SecretKey))
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
                if (this.SecretId != null)
                {
                    hashCode = (hashCode * 59) + this.SecretId.GetHashCode();
                }
                if (this.SecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.SecretKey.GetHashCode();
                }
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
