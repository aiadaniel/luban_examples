//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;


public final class TbMultiIndexList {
    private final java.util.ArrayList<cfg.test.MultiIndexList> _dataList;
    
    public TbMultiIndexList(ByteBuf _buf) {
        _dataList = new java.util.ArrayList<cfg.test.MultiIndexList>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.MultiIndexList _v;
            _v = new cfg.test.MultiIndexList(_buf);
            _dataList.add(_v);
        }
    }

    public java.util.ArrayList<cfg.test.MultiIndexList> getDataList() { return _dataList; }

    public cfg.test.MultiIndexList get(int index) { return _dataList.get(index); }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.test.MultiIndexList v : _dataList) {
            v.resolve(_tables);
        }
    }

}