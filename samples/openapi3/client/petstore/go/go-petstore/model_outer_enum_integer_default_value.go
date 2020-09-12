/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * API version: 1.0.0
 * Generated by: OpenAPI Generator (https://openapi-generator.tech)
 */

package petstore

import (
	"encoding/json"
	"fmt"
)

// OuterEnumIntegerDefaultValue the model 'OuterEnumIntegerDefaultValue'
type OuterEnumIntegerDefaultValue int32

// List of OuterEnumIntegerDefaultValue
const (
	OUTERENUMINTEGERDEFAULTVALUE__0 OuterEnumIntegerDefaultValue = 0
	OUTERENUMINTEGERDEFAULTVALUE__1 OuterEnumIntegerDefaultValue = 1
	OUTERENUMINTEGERDEFAULTVALUE__2 OuterEnumIntegerDefaultValue = 2
)

func (v *OuterEnumIntegerDefaultValue) UnmarshalJSON(src []byte) error {
	var value int32
	err := json.Unmarshal(src, &value)
	if err != nil {
		return err
	}
	enumTypeValue := OuterEnumIntegerDefaultValue(value)
	for _, existing := range []OuterEnumIntegerDefaultValue{ 0, 1, 2,   } {
		if existing == enumTypeValue {
			*v = enumTypeValue
			return nil
		}
	}

	return fmt.Errorf("%+v is not a valid OuterEnumIntegerDefaultValue", value)
}

// Ptr returns reference to OuterEnumIntegerDefaultValue value
func (v OuterEnumIntegerDefaultValue) Ptr() *OuterEnumIntegerDefaultValue {
	return &v
}

type NullableOuterEnumIntegerDefaultValue struct {
	value *OuterEnumIntegerDefaultValue
	isSet bool
}

func (v NullableOuterEnumIntegerDefaultValue) Get() *OuterEnumIntegerDefaultValue {
	return v.value
}

func (v *NullableOuterEnumIntegerDefaultValue) Set(val *OuterEnumIntegerDefaultValue) {
	v.value = val
	v.isSet = true
}

func (v NullableOuterEnumIntegerDefaultValue) IsSet() bool {
	return v.isSet
}

func (v *NullableOuterEnumIntegerDefaultValue) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableOuterEnumIntegerDefaultValue(val *OuterEnumIntegerDefaultValue) *NullableOuterEnumIntegerDefaultValue {
	return &NullableOuterEnumIntegerDefaultValue{value: val, isSet: true}
}

func (v NullableOuterEnumIntegerDefaultValue) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableOuterEnumIntegerDefaultValue) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

