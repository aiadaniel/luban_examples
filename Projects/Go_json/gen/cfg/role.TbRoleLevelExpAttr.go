//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type RoleTbRoleLevelExpAttr struct {
    _dataMap map[int32]*RoleLevelExpAttr
    _dataList []*RoleLevelExpAttr
}

func NewRoleTbRoleLevelExpAttr(_buf []map[string]interface{}) (*RoleTbRoleLevelExpAttr, error) {
	_dataList := make([]*RoleLevelExpAttr, 0, len(_buf))
	dataMap := make(map[int32]*RoleLevelExpAttr)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeRoleLevelExpAttr(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Level] = _v
		}
	}
	return &RoleTbRoleLevelExpAttr{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *RoleTbRoleLevelExpAttr) GetDataMap() map[int32]*RoleLevelExpAttr {
    return table._dataMap
}

func (table *RoleTbRoleLevelExpAttr) GetDataList() []*RoleLevelExpAttr {
    return table._dataList
}

func (table *RoleTbRoleLevelExpAttr) Get(key int32) *RoleLevelExpAttr {
    return table._dataMap[key]
}


