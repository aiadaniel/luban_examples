//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class MultiRowRecord {
    public MultiRowRecord(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        name = __json__.get("name").getAsString();
        { com.google.gson.JsonArray _json0_ = __json__.get("one_rows").getAsJsonArray(); oneRows = new java.util.ArrayList<cfg.test.MultiRowType1>(_json0_.size()); for(JsonElement _e0 : _json0_) { cfg.test.MultiRowType1 _v0;  _v0 = new cfg.test.MultiRowType1(_e0.getAsJsonObject());  oneRows.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("multi_rows1").getAsJsonArray(); multiRows1 = new java.util.ArrayList<cfg.test.MultiRowType1>(_json0_.size()); for(JsonElement _e0 : _json0_) { cfg.test.MultiRowType1 _v0;  _v0 = new cfg.test.MultiRowType1(_e0.getAsJsonObject());  multiRows1.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("multi_rows2").getAsJsonArray(); int __n0 = _json0_.size(); multiRows2 = new cfg.test.MultiRowType1[__n0]; int __index0=0; for(JsonElement __e0 : _json0_) { cfg.test.MultiRowType1 __v0;  __v0 = new cfg.test.MultiRowType1(__e0.getAsJsonObject());  multiRows2[__index0++] = __v0; }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("multi_rows4").getAsJsonArray(); multiRows4 = new java.util.HashMap<Integer, cfg.test.MultiRowType2>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _k0;  _k0 = _e0.getAsJsonArray().get(0).getAsInt(); cfg.test.MultiRowType2 _v0;  _v0 = new cfg.test.MultiRowType2(_e0.getAsJsonArray().get(1).getAsJsonObject());  multiRows4.put(_k0, _v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("multi_rows5").getAsJsonArray(); multiRows5 = new java.util.ArrayList<cfg.test.MultiRowType3>(_json0_.size()); for(JsonElement _e0 : _json0_) { cfg.test.MultiRowType3 _v0;  _v0 = new cfg.test.MultiRowType3(_e0.getAsJsonObject());  multiRows5.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("multi_rows6").getAsJsonArray(); multiRows6 = new java.util.HashMap<Integer, cfg.test.MultiRowType2>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _k0;  _k0 = _e0.getAsJsonArray().get(0).getAsInt(); cfg.test.MultiRowType2 _v0;  _v0 = new cfg.test.MultiRowType2(_e0.getAsJsonArray().get(1).getAsJsonObject());  multiRows6.put(_k0, _v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("multi_rows7").getAsJsonArray(); multiRows7 = new java.util.HashMap<Integer, Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _k0;  _k0 = _e0.getAsJsonArray().get(0).getAsInt(); int _v0;  _v0 = _e0.getAsJsonArray().get(1).getAsInt();  multiRows7.put(_k0, _v0); }   }
    }

    public MultiRowRecord(int id, String name, java.util.ArrayList<cfg.test.MultiRowType1> one_rows, java.util.ArrayList<cfg.test.MultiRowType1> multi_rows1, cfg.test.MultiRowType1[] multi_rows2, java.util.HashMap<Integer, cfg.test.MultiRowType2> multi_rows4, java.util.ArrayList<cfg.test.MultiRowType3> multi_rows5, java.util.HashMap<Integer, cfg.test.MultiRowType2> multi_rows6, java.util.HashMap<Integer, Integer> multi_rows7 ) {
        this.id = id;
        this.name = name;
        this.oneRows = one_rows;
        this.multiRows1 = multi_rows1;
        this.multiRows2 = multi_rows2;
        this.multiRows4 = multi_rows4;
        this.multiRows5 = multi_rows5;
        this.multiRows6 = multi_rows6;
        this.multiRows7 = multi_rows7;
    }

    public static MultiRowRecord deserializeMultiRowRecord(JsonObject __json__) {
        return new MultiRowRecord(__json__);
    }

    public final int id;
    public final String name;
    public final java.util.ArrayList<cfg.test.MultiRowType1> oneRows;
    public final java.util.ArrayList<cfg.test.MultiRowType1> multiRows1;
    public final cfg.test.MultiRowType1[] multiRows2;
    public final java.util.HashMap<Integer, cfg.test.MultiRowType2> multiRows4;
    public final java.util.ArrayList<cfg.test.MultiRowType3> multiRows5;
    public final java.util.HashMap<Integer, cfg.test.MultiRowType2> multiRows6;
    public final java.util.HashMap<Integer, Integer> multiRows7;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.test.MultiRowType1 _e : oneRows) { if (_e != null) _e.resolve(_tables); }
        for(cfg.test.MultiRowType1 _e : multiRows1) { if (_e != null) _e.resolve(_tables); }
        for(cfg.test.MultiRowType1 _e : multiRows2) { if (_e != null) _e.resolve(_tables); }
        for(cfg.test.MultiRowType2 _e : multiRows4.values()) { if (_e != null) _e.resolve(_tables); }
        for(cfg.test.MultiRowType3 _e : multiRows5) { if (_e != null) _e.resolve(_tables); }
        for(cfg.test.MultiRowType2 _e : multiRows6.values()) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "name:" + name + ","
        + "oneRows:" + oneRows + ","
        + "multiRows1:" + multiRows1 + ","
        + "multiRows2:" + multiRows2 + ","
        + "multiRows4:" + multiRows4 + ","
        + "multiRows5:" + multiRows5 + ","
        + "multiRows6:" + multiRows6 + ","
        + "multiRows7:" + multiRows7 + ","
        + "}";
    }
}
