//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type BonusProbabilityItemInfo struct {
    ItemId int32
    Num int32
    Probability float32
}

const TypeId_BonusProbabilityItemInfo = 1547874631

func (*BonusProbabilityItemInfo) GetTypeId() int32 {
    return 1547874631
}

func (_v *BonusProbabilityItemInfo)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["item_id"].(float64); !_ok_ { err = errors.New("item_id error"); return }; _v.ItemId = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["num"].(float64); !_ok_ { err = errors.New("num error"); return }; _v.Num = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["probability"].(float64); !_ok_ { err = errors.New("probability error"); return }; _v.Probability = float32(_tempNum_) }
    return
}

func DeserializeBonusProbabilityItemInfo(_buf map[string]interface{}) (*BonusProbabilityItemInfo, error) {
    v := &BonusProbabilityItemInfo{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
