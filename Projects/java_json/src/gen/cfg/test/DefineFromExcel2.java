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



public final class DefineFromExcel2 {
    public DefineFromExcel2(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        x1 = __json__.get("x1").getAsBoolean();
        x5 = __json__.get("x5").getAsLong();
        x6 = __json__.get("x6").getAsFloat();
        x8 = __json__.get("x8").getAsInt();
        x10 = __json__.get("x10").getAsString();
        x13 = __json__.get("x13").getAsInt();
        x132 = __json__.get("x13_2").getAsInt();
        x14 = cfg.test.DemoDynamic.deserializeDemoDynamic(__json__.get("x14").getAsJsonObject());
        x15 = cfg.test.Shape.deserializeShape(__json__.get("x15").getAsJsonObject());
        { com.google.gson.JsonObject _json0_ = __json__.get("v2").getAsJsonObject(); float __x; __x = _json0_.get("x").getAsFloat(); float __y; __y = _json0_.get("y").getAsFloat(); v2 = new bright.math.Vector2(__x, __y); }
        t1 = __json__.get("t1").getAsLong();
        { com.google.gson.JsonArray _json0_ = __json__.get("k1").getAsJsonArray(); int __n0 = _json0_.size(); k1 = new int[__n0]; int __index0=0; for(JsonElement __e0 : _json0_) { int __v0;  __v0 = __e0.getAsInt();  k1[__index0++] = __v0; }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("k2").getAsJsonArray(); int __n0 = _json0_.size(); k2 = new int[__n0]; int __index0=0; for(JsonElement __e0 : _json0_) { int __v0;  __v0 = __e0.getAsInt();  k2[__index0++] = __v0; }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("k8").getAsJsonArray(); k8 = new java.util.HashMap<Integer, Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _k0;  _k0 = _e0.getAsJsonArray().get(0).getAsInt(); int _v0;  _v0 = _e0.getAsJsonArray().get(1).getAsInt();  k8.put(_k0, _v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("k9").getAsJsonArray(); k9 = new java.util.ArrayList<cfg.test.DemoE2>(_json0_.size()); for(JsonElement _e0 : _json0_) { cfg.test.DemoE2 _v0;  _v0 = new cfg.test.DemoE2(_e0.getAsJsonObject());  k9.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("k10").getAsJsonArray(); k10 = new java.util.ArrayList<bright.math.Vector3>(_json0_.size()); for(JsonElement _e0 : _json0_) { bright.math.Vector3 _v0;  { com.google.gson.JsonObject _json1_ = _e0.getAsJsonObject(); float __x; __x = _json1_.get("x").getAsFloat(); float __y; __y = _json1_.get("y").getAsFloat(); float __z; __z = _json1_.get("z").getAsFloat();  _v0 = new bright.math.Vector3(__x, __y,__z); }  k10.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("k11").getAsJsonArray(); k11 = new java.util.ArrayList<bright.math.Vector4>(_json0_.size()); for(JsonElement _e0 : _json0_) { bright.math.Vector4 _v0;  { com.google.gson.JsonObject _json1_ = _e0.getAsJsonObject(); float __x; __x = _json1_.get("x").getAsFloat(); float __y; __y = _json1_.get("y").getAsFloat(); float __z; __z = _json1_.get("z").getAsFloat();  float __w; __w = _json1_.get("w").getAsFloat(); _v0 = new bright.math.Vector4(__x, __y, __z, __w); }  k11.add(_v0); }   }
    }

    public DefineFromExcel2(int id, boolean x1, long x5, float x6, int x8, String x10, int x13, int x13_2, cfg.test.DemoDynamic x14, cfg.test.Shape x15, bright.math.Vector2 v2, long t1, int[] k1, int[] k2, java.util.HashMap<Integer, Integer> k8, java.util.ArrayList<cfg.test.DemoE2> k9, java.util.ArrayList<bright.math.Vector3> k10, java.util.ArrayList<bright.math.Vector4> k11 ) {
        this.id = id;
        this.x1 = x1;
        this.x5 = x5;
        this.x6 = x6;
        this.x8 = x8;
        this.x10 = x10;
        this.x13 = x13;
        this.x132 = x13_2;
        this.x14 = x14;
        this.x15 = x15;
        this.v2 = v2;
        this.t1 = t1;
        this.k1 = k1;
        this.k2 = k2;
        this.k8 = k8;
        this.k9 = k9;
        this.k10 = k10;
        this.k11 = k11;
    }

    public static DefineFromExcel2 deserializeDefineFromExcel2(JsonObject __json__) {
        return new DefineFromExcel2(__json__);
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
    public final int x13;
    public final int x132;
    public final cfg.test.DemoDynamic x14;
    public final cfg.test.Shape x15;
    public final bright.math.Vector2 v2;
    public final long t1;
    public final int[] k1;
    public final int[] k2;
    public final java.util.HashMap<Integer, Integer> k8;
    public final java.util.ArrayList<cfg.test.DemoE2> k9;
    public final java.util.ArrayList<bright.math.Vector3> k10;
    public final java.util.ArrayList<bright.math.Vector4> k11;


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
        + "x132:" + x132 + ","
        + "x14:" + x14 + ","
        + "x15:" + x15 + ","
        + "v2:" + v2 + ","
        + "t1:" + t1 + ","
        + "k1:" + k1 + ","
        + "k2:" + k2 + ","
        + "k8:" + k8 + ","
        + "k9:" + k9 + ","
        + "k10:" + k10 + ","
        + "k11:" + k11 + ","
        + "}";
    }
}
