
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "luban_examples/go_bin/bright/serialization"

type TestTbDataFromMisc struct {
    _dataMap map[int32]*TestDemoType2
    _dataList []*TestDemoType2
}

func NewTestTbDataFromMisc(_buf *serialization.ByteBuf) (*TestTbDataFromMisc, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*TestDemoType2, 0, size)
		dataMap := make(map[int32]*TestDemoType2)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := DeserializeTestDemoType2(_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.X4] = _v
			}
		}
		return &TestTbDataFromMisc{_dataList:_dataList, _dataMap:dataMap}, nil
	}
}

func (table *TestTbDataFromMisc) GetDataMap() map[int32]*TestDemoType2 {
    return table._dataMap
}

func (table *TestTbDataFromMisc) GetDataList() []*TestDemoType2 {
    return table._dataList
}

func (table *TestTbDataFromMisc) Get(key int32) *TestDemoType2 {
    return table._dataMap[key]
}

