
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.error;

import bright.serialization.*;


public final class TbCodeInfo {
    private final java.util.HashMap<cfg.error.EErrorCode, cfg.error.CodeInfo> _dataMap;
    private final java.util.ArrayList<cfg.error.CodeInfo> _dataList;
    
    public TbCodeInfo(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<cfg.error.EErrorCode, cfg.error.CodeInfo>();
        _dataList = new java.util.ArrayList<cfg.error.CodeInfo>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.error.CodeInfo _v;
            _v = new cfg.error.CodeInfo(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.code, _v);
        }
    }

    public java.util.HashMap<cfg.error.EErrorCode, cfg.error.CodeInfo> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.error.CodeInfo> getDataList() { return _dataList; }

    public cfg.error.CodeInfo get(cfg.error.EErrorCode key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.error.CodeInfo v : _dataList) {
            v.resolve(_tables);
        }
    }
}