//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestMultiRowType3 struct {
    Id int32
    Items []*TestMultiRowType1
}

const TypeId_TestMultiRowType3 = 540474972

func (*TestMultiRowType3) GetTypeId() int32 {
    return 540474972
}

func (_v *TestMultiRowType3)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["items"].([]interface{}); !_ok_ { err = errors.New("items error"); return }

                _v.Items = make([]*TestMultiRowType1, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *TestMultiRowType1
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeTestMultiRowType1(_x_); err != nil { return } }
                    _v.Items = append(_v.Items, _list_v_)
                }
            }

    return
}

func DeserializeTestMultiRowType3(_buf map[string]interface{}) (*TestMultiRowType3, error) {
    v := &TestMultiRowType3{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
