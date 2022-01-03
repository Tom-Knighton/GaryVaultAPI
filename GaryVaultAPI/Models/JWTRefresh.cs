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
    /// Refresh access token.
    /// </summary>
    [DataContract(Name = "JWTRefresh")]
    public partial class JWTRefresh : IEquatable<JWTRefresh>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JWTRefresh" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public JWTRefresh() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JWTRefresh" /> class.
        /// </summary>
        /// <param name="refresh">refresh (required).</param>
        public JWTRefresh(string refresh = default(string))
        {
            // to ensure "refresh" is required (not null)
            if (refresh == null) {
                throw new ArgumentNullException("refresh is a required property for JWTRefresh and cannot be null");
            }
            this.Refresh = refresh;
        }

        /// <summary>
        /// Gets or Sets Refresh
        /// </summary>
        [DataMember(Name = "refresh", IsRequired = true, EmitDefaultValue = false)]
        public string Refresh { get; set; }

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JWTRefresh {\n");
            sb.Append("  Refresh: ").Append(Refresh).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
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
            return this.Equals(input as JWTRefresh);
        }

        /// <summary>
        /// Returns true if JWTRefresh instances are equal
        /// </summary>
        /// <param name="input">Instance of JWTRefresh to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JWTRefresh input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Refresh == input.Refresh ||
                    (this.Refresh != null &&
                    this.Refresh.Equals(input.Refresh))
                ) && 
                (
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
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
                if (this.Refresh != null)
                {
                    hashCode = (hashCode * 59) + this.Refresh.GetHashCode();
                }
                if (this.Access != null)
                {
                    hashCode = (hashCode * 59) + this.Access.GetHashCode();
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
