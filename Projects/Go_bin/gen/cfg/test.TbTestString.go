
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "luban_examples/go_bin/bright/serialization"

type TestTbTestString struct {
    _dataMap map[int32]*TestTestString
    _dataList []*TestTestString
}

func NewTestTbTestString(_buf *serialization.ByteBuf) (*TestTbTestString, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*TestTestString, 0, size)
		dataMap := make(map[int32]*TestTestString)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := DeserializeTestTestString(_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.Id] = _v
			}
		}
		return &TestTbTestString{_dataList:_dataList, _dataMap:dataMap}, nil
	}
}

func (table *TestTbTestString) GetDataMap() map[int32]*TestTestString {
    return table._dataMap
}

func (table *TestTbTestString) GetDataList() []*TestTestString {
    return table._dataList
}

func (table *TestTbTestString) Get(key int32) *TestTestString {
    return table._dataMap[key]
}

