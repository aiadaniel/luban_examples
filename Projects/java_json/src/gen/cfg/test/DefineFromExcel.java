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



public final class DefineFromExcel {
    public DefineFromExcel(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        x1 = __json__.get("x1").getAsBoolean();
        x5 = __json__.get("x5").getAsLong();
        x6 = __json__.get("x6").getAsFloat();
        x8 = __json__.get("x8").getAsInt();
        x10 = __json__.get("x10").getAsString();
        x13 = cfg.test.ETestQuality.valueOf(__json__.get("x13").getAsInt());
        x14 = cfg.test.DemoDynamic.deserializeDemoDynamic(__json__.get("x14").getAsJsonObject());
        x15 = cfg.test.Shape.deserializeShape(__json__.get("x15").getAsJsonObject());
        { com.google.gson.JsonObject _json0_ = __json__.get("v2").getAsJsonObject(); float __x; __x = _json0_.get("x").getAsFloat(); float __y; __y = _json0_.get("y").getAsFloat(); v2 = new bright.math.Vector2(__x, __y); }
        t1 = __json__.get("t1").getAsInt();
        { com.google.gson.JsonArray _json0_ = __json__.get("k1").getAsJsonArray(); int _n = _json0_.size(); k1 = new int[_n]; int _index=0; for(JsonElement __e : _json0_) { int __v;  __v = __e.getAsInt();  k1[_index++] = __v; }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("k2").getAsJsonArray(); int _n = _json0_.size(); k2 = new int[_n]; int _index=0; for(JsonElement __e : _json0_) { int __v;  __v = __e.getAsInt();  k2[_index++] = __v; }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("k8").getAsJsonArray(); k8 = new java.util.HashMap<Integer, Integer>(_json0_.size()); for(JsonElement __e : _json0_) { int __k;  __k = __e.getAsJsonArray().get(0).getAsInt(); int __v;  __v = __e.getAsJsonArray().get(1).getAsInt();  k8.put(__k, __v); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("k9").getAsJsonArray(); k9 = new java.util.ArrayList<cfg.test.DemoE2>(_json0_.size()); for(JsonElement __e : _json0_) { cfg.test.DemoE2 __v;  __v = new cfg.test.DemoE2(__e.getAsJsonObject());  k9.add(__v); }   }
    }

    public DefineFromExcel(int id, boolean x1, long x5, float x6, int x8, String x10, cfg.test.ETestQuality x13, cfg.test.DemoDynamic x14, cfg.test.Shape x15, bright.math.Vector2 v2, int t1, int[] k1, int[] k2, java.util.HashMap<Integer, Integer> k8, java.util.ArrayList<cfg.test.DemoE2> k9 ) {
        this.id = id;
        this.x1 = x1;
        this.x5 = x5;
        this.x6 = x6;
        this.x8 = x8;
        this.x10 = x10;
        this.x13 = x13;
        this.x14 = x14;
        this.x15 = x15;
        this.v2 = v2;
        this.t1 = t1;
        this.k1 = k1;
        this.k2 = k2;
        this.k8 = k8;
        this.k9 = k9;
    }

    public static DefineFromExcel deserializeDefineFromExcel(JsonObject __json__) {
        return new DefineFromExcel(__json__);
    }

    /**
     * 这是id
     */
    public final int id;
    /**
     * 字段x1
     */
    public final boolean x1;
    public final long x5;
    public final float x6;
    public final int x8;
    public final String x10;
    public final cfg.test.ETestQuality x13;
    public final cfg.test.DemoDynamic x14;
    public final cfg.test.Shape x15;
    public final bright.math.Vector2 v2;
    public final int t1;
    public final int[] k1;
    public final int[] k2;
    public final java.util.HashMap<Integer, Integer> k8;
    public final java.util.ArrayList<cfg.test.DemoE2> k9;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        if (x14 != null) {x14.resolve(_tables);}
        if (x15 != null) {x15.resolve(_tables);}
        for(cfg.test.DemoE2 _e : k9) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "x1:" + x1 + ","
        + "x5:" + x5 + ","
        + "x6:" + x6 + ","
        + "x8:" + x8 + ","
        + "x10:" + x10 + ","
        + "x13:" + x13 + ","
        + "x14:" + x14 + ","
        + "x15:" + x15 + ","
        + "v2:" + v2 + ","
        + "t1:" + t1 + ","
        + "k1:" + k1 + ","
        + "k2:" + k2 + ","
        + "k8:" + k8 + ","
        + "k9:" + k9 + ","
        + "}";
    }
}
