//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiUpdateDailyBehaviorProps struct {
    Id int32
    NodeName string
    SatietyKey string
    EnergyKey string
    MoodKey string
    SatietyLowerThresholdKey string
    SatietyUpperThresholdKey string
    EnergyLowerThresholdKey string
    EnergyUpperThresholdKey string
    MoodLowerThresholdKey string
    MoodUpperThresholdKey string
}

const TypeId_AiUpdateDailyBehaviorProps = -61887372

func (*AiUpdateDailyBehaviorProps) GetTypeId() int32 {
    return -61887372
}

func (_v *AiUpdateDailyBehaviorProps)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.NodeName, _ok_ = _buf["node_name"].(string); !_ok_ { err = errors.New("node_name error"); return } }
    { var _ok_ bool; if _v.SatietyKey, _ok_ = _buf["satiety_key"].(string); !_ok_ { err = errors.New("satiety_key error"); return } }
    { var _ok_ bool; if _v.EnergyKey, _ok_ = _buf["energy_key"].(string); !_ok_ { err = errors.New("energy_key error"); return } }
    { var _ok_ bool; if _v.MoodKey, _ok_ = _buf["mood_key"].(string); !_ok_ { err = errors.New("mood_key error"); return } }
    { var _ok_ bool; if _v.SatietyLowerThresholdKey, _ok_ = _buf["satiety_lower_threshold_key"].(string); !_ok_ { err = errors.New("satiety_lower_threshold_key error"); return } }
    { var _ok_ bool; if _v.SatietyUpperThresholdKey, _ok_ = _buf["satiety_upper_threshold_key"].(string); !_ok_ { err = errors.New("satiety_upper_threshold_key error"); return } }
    { var _ok_ bool; if _v.EnergyLowerThresholdKey, _ok_ = _buf["energy_lower_threshold_key"].(string); !_ok_ { err = errors.New("energy_lower_threshold_key error"); return } }
    { var _ok_ bool; if _v.EnergyUpperThresholdKey, _ok_ = _buf["energy_upper_threshold_key"].(string); !_ok_ { err = errors.New("energy_upper_threshold_key error"); return } }
    { var _ok_ bool; if _v.MoodLowerThresholdKey, _ok_ = _buf["mood_lower_threshold_key"].(string); !_ok_ { err = errors.New("mood_lower_threshold_key error"); return } }
    { var _ok_ bool; if _v.MoodUpperThresholdKey, _ok_ = _buf["mood_upper_threshold_key"].(string); !_ok_ { err = errors.New("mood_upper_threshold_key error"); return } }
    return
}

func DeserializeAiUpdateDailyBehaviorProps(_buf map[string]interface{}) (*AiUpdateDailyBehaviorProps, error) {
    v := &AiUpdateDailyBehaviorProps{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
