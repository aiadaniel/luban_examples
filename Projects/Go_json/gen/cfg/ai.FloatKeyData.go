//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiFloatKeyData struct {
    Value float32
}

const TypeId_AiFloatKeyData = -719747885

func (*AiFloatKeyData) GetTypeId() int32 {
    return -719747885
}

func (_v *AiFloatKeyData)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["value"].(float64); !_ok_ { err = errors.New("value error"); return }; _v.Value = float32(_tempNum_) }
    return
}

func DeserializeAiFloatKeyData(_buf map[string]interface{}) (*AiFloatKeyData, error) {
    v := &AiFloatKeyData{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
