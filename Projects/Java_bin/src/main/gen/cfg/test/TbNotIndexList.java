//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;


public final class TbNotIndexList {
    private final java.util.ArrayList<cfg.test.NotIndexList> _dataList;
    
    public TbNotIndexList(ByteBuf _buf) {
        _dataList = new java.util.ArrayList<cfg.test.NotIndexList>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.NotIndexList _v;
            _v = new cfg.test.NotIndexList(_buf);
            _dataList.add(_v);
        }
    }

    public java.util.ArrayList<cfg.test.NotIndexList> getDataList() { return _dataList; }

    public cfg.test.NotIndexList get(int index) { return _dataList.get(index); }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.test.NotIndexList v : _dataList) {
            v.resolve(_tables);
        }
    }

}