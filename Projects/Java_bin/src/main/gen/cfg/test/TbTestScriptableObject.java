//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;


public final class TbTestScriptableObject {
    private final java.util.HashMap<Integer, cfg.test.TestScriptableObject> _dataMap;
    private final java.util.ArrayList<cfg.test.TestScriptableObject> _dataList;
    
    public TbTestScriptableObject(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.TestScriptableObject>();
        _dataList = new java.util.ArrayList<cfg.test.TestScriptableObject>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.TestScriptableObject _v;
            _v = new cfg.test.TestScriptableObject(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.TestScriptableObject> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.TestScriptableObject> getDataList() { return _dataList; }

    public cfg.test.TestScriptableObject get(int key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.test.TestScriptableObject v : _dataList) {
            v.resolve(_tables);
        }
    }
}