//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type ConditionMinMaxLevel struct {
    Min int32
    Max int32
}

const TypeId_ConditionMinMaxLevel = 907499647

func (*ConditionMinMaxLevel) GetTypeId() int32 {
    return 907499647
}

func (_v *ConditionMinMaxLevel)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["min"].(float64); !_ok_ { err = errors.New("min error"); return }; _v.Min = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["max"].(float64); !_ok_ { err = errors.New("max error"); return }; _v.Max = int32(_tempNum_) }
    return
}

func DeserializeConditionMinMaxLevel(_buf map[string]interface{}) (*ConditionMinMaxLevel, error) {
    v := &ConditionMinMaxLevel{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
