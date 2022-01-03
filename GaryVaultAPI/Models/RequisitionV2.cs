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
    /// Get requisition by id.
    /// </summary>
    [DataContract(Name = "RequisitionV2")]
    public partial class RequisitionV2 : IEquatable<RequisitionV2>, IValidatableObject
    {

        /// <summary>
        /// status of this requisition
        /// </summary>
        /// <value>status of this requisition</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public Status1c5Enum? Status { get; set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequisitionV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequisitionV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequisitionV2" /> class.
        /// </summary>
        /// <param name="redirect">redirect URL to your application after end-user authorization with ASPSP (required).</param>
        /// <param name="institutionId">an Institution ID for this Requisition (required).</param>
        /// <param name="agreement">EUA associated with this requisition.</param>
        /// <param name="reference">additional ID to identify the end user.</param>
        /// <param name="userLanguage">A two-letter country code (ISO 639-1).</param>
        /// <param name="ssn">optional SSN field to verify ownership of the account.</param>
        /// <param name="accountSelection">option to enable account selection view for the end user (default to false).</param>
        public RequisitionV2(string redirect = default(string), string institutionId = default(string), Guid agreement = default(Guid), string reference = default(string), string userLanguage = default(string), string ssn = default(string), bool accountSelection = false)
        {
            // to ensure "redirect" is required (not null)
            if (redirect == null) {
                throw new ArgumentNullException("redirect is a required property for RequisitionV2 and cannot be null");
            }
            this.Redirect = redirect;
            // to ensure "institutionId" is required (not null)
            if (institutionId == null) {
                throw new ArgumentNullException("institutionId is a required property for RequisitionV2 and cannot be null");
            }
            this.InstitutionId = institutionId;
            this.Agreement = agreement;
            this.Reference = reference;
            this.UserLanguage = userLanguage;
            this.Ssn = ssn;
            this.AccountSelection = accountSelection;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The date &amp; time at which the requisition was created.
        /// </summary>
        /// <value>The date &amp; time at which the requisition was created.</value>
        [DataMember(Name = "created", EmitDefaultValue = true)]
        public DateTime? Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// redirect URL to your application after end-user authorization with ASPSP
        /// </summary>
        /// <value>redirect URL to your application after end-user authorization with ASPSP</value>
        [DataMember(Name = "redirect", IsRequired = true, EmitDefaultValue = true)]
        public string Redirect { get; set; }

        /// <summary>
        /// an Institution ID for this Requisition
        /// </summary>
        /// <value>an Institution ID for this Requisition</value>
        [DataMember(Name = "institution_id", IsRequired = true, EmitDefaultValue = false)]
        public string InstitutionId { get; set; }

        /// <summary>
        /// EUA associated with this requisition
        /// </summary>
        /// <value>EUA associated with this requisition</value>
        [DataMember(Name = "agreement", EmitDefaultValue = false)]
        public Guid Agreement { get; set; }

        /// <summary>
        /// additional ID to identify the end user
        /// </summary>
        /// <value>additional ID to identify the end user</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// array of account IDs retrieved within a scope of this requisition
        /// </summary>
        /// <value>array of account IDs retrieved within a scope of this requisition</value>
        [DataMember(Name = "accounts", EmitDefaultValue = false)]
        public List<Guid> Accounts { get; private set; }

        /// <summary>
        /// Returns false as Accounts should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccounts()
        {
            return false;
        }
        /// <summary>
        /// A two-letter country code (ISO 639-1)
        /// </summary>
        /// <value>A two-letter country code (ISO 639-1)</value>
        [DataMember(Name = "user_language", EmitDefaultValue = false)]
        public string UserLanguage { get; set; }

        /// <summary>
        /// link to initiate authorization with Institution
        /// </summary>
        /// <value>link to initiate authorization with Institution</value>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; private set; }

        /// <summary>
        /// Returns false as Link should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLink()
        {
            return false;
        }
        /// <summary>
        /// optional SSN field to verify ownership of the account
        /// </summary>
        /// <value>optional SSN field to verify ownership of the account</value>
        [DataMember(Name = "ssn", EmitDefaultValue = false)]
        public string Ssn { get; set; }

        /// <summary>
        /// option to enable account selection view for the end user
        /// </summary>
        /// <value>option to enable account selection view for the end user</value>
        [DataMember(Name = "account_selection", EmitDefaultValue = true)]
        public bool AccountSelection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequisitionV2 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Redirect: ").Append(Redirect).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
            sb.Append("  Agreement: ").Append(Agreement).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  UserLanguage: ").Append(UserLanguage).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Ssn: ").Append(Ssn).Append("\n");
            sb.Append("  AccountSelection: ").Append(AccountSelection).Append("\n");
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
            return this.Equals(input as RequisitionV2);
        }

        /// <summary>
        /// Returns true if RequisitionV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of RequisitionV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequisitionV2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Redirect == input.Redirect ||
                    (this.Redirect != null &&
                    this.Redirect.Equals(input.Redirect))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.InstitutionId == input.InstitutionId ||
                    (this.InstitutionId != null &&
                    this.InstitutionId.Equals(input.InstitutionId))
                ) && 
                (
                    this.Agreement == input.Agreement ||
                    (this.Agreement != null &&
                    this.Agreement.Equals(input.Agreement))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.UserLanguage == input.UserLanguage ||
                    (this.UserLanguage != null &&
                    this.UserLanguage.Equals(input.UserLanguage))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Ssn == input.Ssn ||
                    (this.Ssn != null &&
                    this.Ssn.Equals(input.Ssn))
                ) && 
                (
                    this.AccountSelection == input.AccountSelection ||
                    this.AccountSelection.Equals(input.AccountSelection)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Redirect != null)
                {
                    hashCode = (hashCode * 59) + this.Redirect.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.InstitutionId != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionId.GetHashCode();
                }
                if (this.Agreement != null)
                {
                    hashCode = (hashCode * 59) + this.Agreement.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Accounts != null)
                {
                    hashCode = (hashCode * 59) + this.Accounts.GetHashCode();
                }
                if (this.UserLanguage != null)
                {
                    hashCode = (hashCode * 59) + this.UserLanguage.GetHashCode();
                }
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
                }
                if (this.Ssn != null)
                {
                    hashCode = (hashCode * 59) + this.Ssn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountSelection.GetHashCode();
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
            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 256.", new [] { "Reference" });
            }

            // UserLanguage (string) maxLength
            if (this.UserLanguage != null && this.UserLanguage.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserLanguage, length must be less than 5.", new [] { "UserLanguage" });
            }

            // Ssn (string) maxLength
            if (this.Ssn != null && this.Ssn.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ssn, length must be less than 64.", new [] { "Ssn" });
            }

            yield break;
        }
    }

}
