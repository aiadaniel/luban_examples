//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type BlueprintBlueprintMethod struct {
    Name string
    Desc string
    IsStatic bool
    ReturnType string
    Parameters []*BlueprintParamInfo
}

const TypeId_BlueprintBlueprintMethod = -696408103

func (*BlueprintBlueprintMethod) GetTypeId() int32 {
    return -696408103
}

func (_v *BlueprintBlueprintMethod)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; if _v.Name, _ok_ = _buf["name"].(string); !_ok_ { err = errors.New("name error"); return } }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
    { var _ok_ bool; if _v.IsStatic, _ok_ = _buf["is_static"].(bool); !_ok_ { err = errors.New("is_static error"); return } }
    { var _ok_ bool; if _v.ReturnType, _ok_ = _buf["return_type"].(string); !_ok_ { err = errors.New("return_type error"); return } }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["parameters"].([]interface{}); !_ok_ { err = errors.New("parameters error"); return }

                _v.Parameters = make([]*BlueprintParamInfo, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *BlueprintParamInfo
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeBlueprintParamInfo(_x_); err != nil { return } }
                    _v.Parameters = append(_v.Parameters, _list_v_)
                }
            }

    return
}

func DeserializeBlueprintBlueprintMethod(_buf map[string]interface{}) (*BlueprintBlueprintMethod, error) {
    v := &BlueprintBlueprintMethod{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
