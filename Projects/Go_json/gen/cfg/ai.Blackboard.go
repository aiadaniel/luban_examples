//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiBlackboard struct {
    Name string
    Desc string
    ParentName string
    Keys []*AiBlackboardKey
}

const TypeId_AiBlackboard = 1576193005

func (*AiBlackboard) GetTypeId() int32 {
    return 1576193005
}

func (_v *AiBlackboard)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; if _v.Name, _ok_ = _buf["name"].(string); !_ok_ { err = errors.New("name error"); return } }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
    { var _ok_ bool; if _v.ParentName, _ok_ = _buf["parent_name"].(string); !_ok_ { err = errors.New("parent_name error"); return } }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["keys"].([]interface{}); !_ok_ { err = errors.New("keys error"); return }

                _v.Keys = make([]*AiBlackboardKey, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *AiBlackboardKey
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeAiBlackboardKey(_x_); err != nil { return } }
                    _v.Keys = append(_v.Keys, _list_v_)
                }
            }

    return
}

func DeserializeAiBlackboard(_buf map[string]interface{}) (*AiBlackboard, error) {
    v := &AiBlackboard{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
