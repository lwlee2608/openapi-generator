/**
* OpenAPI Petstore
* This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
*
* The version of the OpenAPI document: 1.0.0
* 
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/
package org.openapitools.client.models


import kotlinx.serialization.*
import kotlinx.serialization.internal.CommonEnumSerializer

/**
 * 
 * @param id 
 * @param username 
 * @param firstName 
 * @param lastName 
 * @param email 
 * @param password 
 * @param phone 
 * @param userStatus User Status
 */
@Serializable
data class User (
    @SerialName(value = "id") val id: kotlin.Long? = null,
    @SerialName(value = "username") val username: kotlin.String? = null,
    @SerialName(value = "firstName") val firstName: kotlin.String? = null,
    @SerialName(value = "lastName") val lastName: kotlin.String? = null,
    @SerialName(value = "email") val email: kotlin.String? = null,
    @SerialName(value = "password") val password: kotlin.String? = null,
    @SerialName(value = "phone") val phone: kotlin.String? = null,
    /* User Status */
    @SerialName(value = "userStatus") val userStatus: kotlin.Int? = null
)

