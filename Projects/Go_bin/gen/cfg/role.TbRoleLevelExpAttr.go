
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "luban_examples/go_bin/bright/serialization"

type RoleTbRoleLevelExpAttr struct {
    _dataMap map[int32]*RoleLevelExpAttr
    _dataList []*RoleLevelExpAttr
}

func NewRoleTbRoleLevelExpAttr(_buf *serialization.ByteBuf) (*RoleTbRoleLevelExpAttr, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*RoleLevelExpAttr, 0, size)
		dataMap := make(map[int32]*RoleLevelExpAttr)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := DeserializeRoleLevelExpAttr(_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.Level] = _v
			}
		}
		return &RoleTbRoleLevelExpAttr{_dataList:_dataList, _dataMap:dataMap}, nil
	}
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

