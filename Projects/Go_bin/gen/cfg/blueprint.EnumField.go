
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import (
    "luban_examples/go_bin/bright/serialization"
)

import "errors"

type BlueprintEnumField struct {
    Name string
    Value int32
}

const TypeId_BlueprintEnumField = 1830049470

func (*BlueprintEnumField) GetTypeId() int32 {
    return 1830049470
}

func (_v *BlueprintEnumField)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *BlueprintEnumField)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Name, err = _buf.ReadString(); err != nil { err = errors.New("_v.Name error"); return } }
    { if _v.Value, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Value error"); return } }
    return
}

func DeserializeBlueprintEnumField(_buf *serialization.ByteBuf) (*BlueprintEnumField, error) {
    v := &BlueprintEnumField{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
