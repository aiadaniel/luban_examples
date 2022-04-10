//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type ItemItem struct {
    Id int32
    Name string
    MajorType int32
    MinorType int32
    MaxPileNum int32
    Quality int32
    Icon string
    IconBackgroud string
    IconMask string
    Desc string
    ShowOrder int32
    Quantifier string
    ShowInBag bool
    MinShowLevel int32
    BatchUsable bool
    ProgressTimeWhenUse float32
    ShowHintWhenUse bool
    Droppable bool
    Price *int32
    UseType int32
    LevelUpId *int32
}

const TypeId_ItemItem = 2107285806

func (*ItemItem) GetTypeId() int32 {
    return 2107285806
}

func (_v *ItemItem)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.Name, _ok_ = _buf["name"].(string); !_ok_ { err = errors.New("name error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["major_type"].(float64); !_ok_ { err = errors.New("major_type error"); return }; _v.MajorType = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["minor_type"].(float64); !_ok_ { err = errors.New("minor_type error"); return }; _v.MinorType = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["max_pile_num"].(float64); !_ok_ { err = errors.New("max_pile_num error"); return }; _v.MaxPileNum = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["quality"].(float64); !_ok_ { err = errors.New("quality error"); return }; _v.Quality = int32(_tempNum_) }
    { var _ok_ bool; if _v.Icon, _ok_ = _buf["icon"].(string); !_ok_ { err = errors.New("icon error"); return } }
    { var _ok_ bool; if _v.IconBackgroud, _ok_ = _buf["icon_backgroud"].(string); !_ok_ { err = errors.New("icon_backgroud error"); return } }
    { var _ok_ bool; if _v.IconMask, _ok_ = _buf["icon_mask"].(string); !_ok_ { err = errors.New("icon_mask error"); return } }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["show_order"].(float64); !_ok_ { err = errors.New("show_order error"); return }; _v.ShowOrder = int32(_tempNum_) }
    { var _ok_ bool; if _v.Quantifier, _ok_ = _buf["quantifier"].(string); !_ok_ { err = errors.New("quantifier error"); return } }
    { var _ok_ bool; if _v.ShowInBag, _ok_ = _buf["show_in_bag"].(bool); !_ok_ { err = errors.New("show_in_bag error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["min_show_level"].(float64); !_ok_ { err = errors.New("min_show_level error"); return }; _v.MinShowLevel = int32(_tempNum_) }
    { var _ok_ bool; if _v.BatchUsable, _ok_ = _buf["batch_usable"].(bool); !_ok_ { err = errors.New("batch_usable error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["progress_time_when_use"].(float64); !_ok_ { err = errors.New("progress_time_when_use error"); return }; _v.ProgressTimeWhenUse = float32(_tempNum_) }
    { var _ok_ bool; if _v.ShowHintWhenUse, _ok_ = _buf["show_hint_when_use"].(bool); !_ok_ { err = errors.New("show_hint_when_use error"); return } }
    { var _ok_ bool; if _v.Droppable, _ok_ = _buf["droppable"].(bool); !_ok_ { err = errors.New("droppable error"); return } }
    { var _ok_ bool; var __json_price__ interface{}; if __json_price__, _ok_ = _buf["price"]; !_ok_ || __json_price__ == nil { _v.Price = nil } else { var __x__ int32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_price__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int32(_x_) }; _v.Price = &__x__ }}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["use_type"].(float64); !_ok_ { err = errors.New("use_type error"); return }; _v.UseType = int32(_tempNum_) }
    { var _ok_ bool; var __json_level_up_id__ interface{}; if __json_level_up_id__, _ok_ = _buf["level_up_id"]; !_ok_ || __json_level_up_id__ == nil { _v.LevelUpId = nil } else { var __x__ int32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_level_up_id__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int32(_x_) }; _v.LevelUpId = &__x__ }}
    return
}

func DeserializeItemItem(_buf map[string]interface{}) (*ItemItem, error) {
    v := &ItemItem{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
