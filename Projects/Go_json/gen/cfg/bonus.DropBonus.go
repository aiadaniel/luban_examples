//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type BonusDropBonus struct {
    Id int32
}

const TypeId_BonusDropBonus = 1959868225

func (*BonusDropBonus) GetTypeId() int32 {
    return 1959868225
}

func (_v *BonusDropBonus)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    return
}

func DeserializeBonusDropBonus(_buf map[string]interface{}) (*BonusDropBonus, error) {
    v := &BonusDropBonus{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
