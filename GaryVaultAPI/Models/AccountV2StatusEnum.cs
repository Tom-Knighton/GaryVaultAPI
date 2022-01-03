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
    /// Defines AccountV2StatusEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountV2StatusEnum
    {
        /// <summary>
        /// Enum DISCOVEREDUserHasSuccessfullyAuthenticatedAndAccountIsDiscovered for value: {\&quot;DISCOVERED\&quot;:\&quot;User has successfully authenticated and account is discovered\&quot;}
        /// </summary>
        [EnumMember(Value = "{\"DISCOVERED\":\"User has successfully authenticated and account is discovered\"}")]
        DISCOVEREDUserHasSuccessfullyAuthenticatedAndAccountIsDiscovered = 1,

        /// <summary>
        /// Enum PROCESSINGAccountIsBeingProcessedByTheInstitution for value: {\&quot;PROCESSING\&quot;:\&quot;Account is being processed by the Institution\&quot;}
        /// </summary>
        [EnumMember(Value = "{\"PROCESSING\":\"Account is being processed by the Institution\"}")]
        PROCESSINGAccountIsBeingProcessedByTheInstitution = 2,

        /// <summary>
        /// Enum ERRORAnErrorWasEncounteredWhenProcessingAccount for value: {\&quot;ERROR\&quot;:\&quot;An error was encountered when processing account\&quot;}
        /// </summary>
        [EnumMember(Value = "{\"ERROR\":\"An error was encountered when processing account\"}")]
        ERRORAnErrorWasEncounteredWhenProcessingAccount = 3,

        /// <summary>
        /// Enum EXPIREDAccessToAccountHasExpiredAsSetInEndUserAgreement for value: {\&quot;EXPIRED\&quot;:\&quot;Access to account has expired as set in End User Agreement\&quot;}
        /// </summary>
        [EnumMember(Value = "{\"EXPIRED\":\"Access to account has expired as set in End User Agreement\"}")]
        EXPIREDAccessToAccountHasExpiredAsSetInEndUserAgreement = 4,

        /// <summary>
        /// Enum READYAccountHasBeenSuccessfullyProcessed for value: {\&quot;READY\&quot;:\&quot;Account has been successfully processed\&quot;}
        /// </summary>
        [EnumMember(Value = "{\"READY\":\"Account has been successfully processed\"}")]
        READYAccountHasBeenSuccessfullyProcessed = 5,

        /// <summary>
        /// Enum SUSPENDEDAccountHasBeenSuspendedmoreThan10ConsecutiveFailedAttemptsToAccessTheAccount for value: {\&quot;SUSPENDED\&quot;:\&quot;Account has been suspended (more than 10 consecutive failed attempts to access the account)\&quot;}
        /// </summary>
        [EnumMember(Value = "{\"SUSPENDED\":\"Account has been suspended (more than 10 consecutive failed attempts to access the account)\"}")]
        SUSPENDEDAccountHasBeenSuspendedmoreThan10ConsecutiveFailedAttemptsToAccessTheAccount = 6

    }

}
