//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type BonusDropInfo struct {
    Id int32
    Desc string
    ClientShowItems []*BonusShowItemInfo
    Bonus interface{}
}

const TypeId_BonusDropInfo = -2014781108

func (*BonusDropInfo) GetTypeId() int32 {
    return -2014781108
}

func (_v *BonusDropInfo)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["client_show_items"].([]interface{}); !_ok_ { err = errors.New("client_show_items error"); return }

                _v.ClientShowItems = make([]*BonusShowItemInfo, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *BonusShowItemInfo
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeBonusShowItemInfo(_x_); err != nil { return } }
                    _v.ClientShowItems = append(_v.ClientShowItems, _list_v_)
                }
            }

    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["bonus"].(map[string]interface{}); !_ok_ { err = errors.New("bonus error"); return }; if _v.Bonus, err = DeserializeBonusBonus(_x_); err != nil { return } }
    return
}

func DeserializeBonusDropInfo(_buf map[string]interface{}) (*BonusDropInfo, error) {
    v := &BonusDropInfo{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
