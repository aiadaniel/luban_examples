//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type TestTbTestScriptableObject struct {
    _dataMap map[int32]*TestTestScriptableObject
    _dataList []*TestTestScriptableObject
}

func NewTestTbTestScriptableObject(_buf []map[string]interface{}) (*TestTbTestScriptableObject, error) {
	_dataList := make([]*TestTestScriptableObject, 0, len(_buf))
	dataMap := make(map[int32]*TestTestScriptableObject)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeTestTestScriptableObject(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &TestTbTestScriptableObject{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *TestTbTestScriptableObject) GetDataMap() map[int32]*TestTestScriptableObject {
    return table._dataMap
}

func (table *TestTbTestScriptableObject) GetDataList() []*TestTestScriptableObject {
    return table._dataList
}

func (table *TestTbTestScriptableObject) Get(key int32) *TestTestScriptableObject {
    return table._dataMap[key]
}


