//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestDemoE1 struct {
    X1 int32
    X3 int32
    X4 int32
}

const TypeId_TestDemoE1 = -2138341717

func (*TestDemoE1) GetTypeId() int32 {
    return -2138341717
}

func (_v *TestDemoE1)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x1"].(float64); !_ok_ { err = errors.New("x1 error"); return }; _v.X1 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x3"].(float64); !_ok_ { err = errors.New("x3 error"); return }; _v.X3 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x4"].(float64); !_ok_ { err = errors.New("x4 error"); return }; _v.X4 = int32(_tempNum_) }
    return
}

func DeserializeTestDemoE1(_buf map[string]interface{}) (*TestDemoE1, error) {
    v := &TestDemoE1{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
