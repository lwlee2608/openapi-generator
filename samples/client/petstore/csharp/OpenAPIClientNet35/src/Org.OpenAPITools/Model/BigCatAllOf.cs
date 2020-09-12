/* 
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// BigCatAllOf
    /// </summary>
    [DataContract]
    public partial class BigCatAllOf :  IEquatable<BigCatAllOf>
    {
        /// <summary>
        /// Defines Kind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KindEnum
        {
            /// <summary>
            /// Enum Lions for value: lions
            /// </summary>
            [EnumMember(Value = "lions")]
            Lions = 1,

            /// <summary>
            /// Enum Tigers for value: tigers
            /// </summary>
            [EnumMember(Value = "tigers")]
            Tigers = 2,

            /// <summary>
            /// Enum Leopards for value: leopards
            /// </summary>
            [EnumMember(Value = "leopards")]
            Leopards = 3,

            /// <summary>
            /// Enum Jaguars for value: jaguars
            /// </summary>
            [EnumMember(Value = "jaguars")]
            Jaguars = 4

        }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public KindEnum? Kind { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BigCatAllOf" /> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        public BigCatAllOf(KindEnum? kind = default(KindEnum?))
        {
            this.Kind = kind;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BigCatAllOf {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
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
            return this.Equals(input as BigCatAllOf);
        }

        /// <summary>
        /// Returns true if BigCatAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of BigCatAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BigCatAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
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
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                return hashCode;
            }
        }

    }

}
