//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type ErrorTbCodeInfo struct {
    _dataMap map[int32]*ErrorCodeInfo
    _dataList []*ErrorCodeInfo
}

func NewErrorTbCodeInfo(_buf []map[string]interface{}) (*ErrorTbCodeInfo, error) {
	_dataList := make([]*ErrorCodeInfo, 0, len(_buf))
	dataMap := make(map[int32]*ErrorCodeInfo)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeErrorCodeInfo(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Code] = _v
		}
	}
	return &ErrorTbCodeInfo{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *ErrorTbCodeInfo) GetDataMap() map[int32]*ErrorCodeInfo {
    return table._dataMap
}

func (table *ErrorTbCodeInfo) GetDataList() []*ErrorCodeInfo {
    return table._dataList
}

func (table *ErrorTbCodeInfo) Get(key int32) *ErrorCodeInfo {
    return table._dataMap[key]
}


