
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

type BonusItem struct {
    ItemId int32
    Amount int32
}

const TypeId_BonusItem = 1689011106

func (*BonusItem) GetTypeId() int32 {
    return 1689011106
}

func (_v *BonusItem)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *BonusItem)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.ItemId, err = _buf.ReadInt(); err != nil { err = errors.New("_v.ItemId error"); return } }
    { if _v.Amount, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Amount error"); return } }
    return
}

func DeserializeBonusItem(_buf *serialization.ByteBuf) (*BonusItem, error) {
    v := &BonusItem{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
