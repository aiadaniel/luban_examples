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



public final class TestRef {
    public TestRef(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        x1 = __json__.get("x1").getAsInt();
        x12 = __json__.get("x1_2").getAsInt();
        x2 = __json__.get("x2").getAsInt();
        x3 = __json__.get("x3").getAsInt();
        x4 = __json__.get("x4").getAsInt();
        { com.google.gson.JsonArray _json0_ = __json__.get("a1").getAsJsonArray(); int __n0 = _json0_.size(); a1 = new int[__n0]; int __index0=0; for(JsonElement __e0 : _json0_) { int __v0;  __v0 = __e0.getAsInt();  a1[__index0++] = __v0; }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("a2").getAsJsonArray(); int __n0 = _json0_.size(); a2 = new int[__n0]; int __index0=0; for(JsonElement __e0 : _json0_) { int __v0;  __v0 = __e0.getAsInt();  a2[__index0++] = __v0; }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("b1").getAsJsonArray(); b1 = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _v0;  _v0 = _e0.getAsInt();  b1.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("b2").getAsJsonArray(); b2 = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _v0;  _v0 = _e0.getAsInt();  b2.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("c1").getAsJsonArray(); c1 = new java.util.HashSet<Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _v0;  _v0 = _e0.getAsInt();  c1.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("c2").getAsJsonArray(); c2 = new java.util.HashSet<Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _v0;  _v0 = _e0.getAsInt();  c2.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("d1").getAsJsonArray(); d1 = new java.util.HashMap<Integer, Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _k0;  _k0 = _e0.getAsJsonArray().get(0).getAsInt(); int _v0;  _v0 = _e0.getAsJsonArray().get(1).getAsInt();  d1.put(_k0, _v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("d2").getAsJsonArray(); d2 = new java.util.HashMap<Integer, Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _k0;  _k0 = _e0.getAsJsonArray().get(0).getAsInt(); int _v0;  _v0 = _e0.getAsJsonArray().get(1).getAsInt();  d2.put(_k0, _v0); }   }
        e1 = __json__.get("e1").getAsInt();
        e2 = __json__.get("e2").getAsLong();
        e3 = __json__.get("e3").getAsString();
        f1 = __json__.get("f1").getAsInt();
        f2 = __json__.get("f2").getAsLong();
        f3 = __json__.get("f3").getAsString();
        s1 = cfg.test.RefDynamicBase.deserializeRefDynamicBase(__json__.get("s1").getAsJsonObject());
    }

    public TestRef(int id, int x1, int x1_2, int x2, int x3, int x4, int[] a1, int[] a2, java.util.ArrayList<Integer> b1, java.util.ArrayList<Integer> b2, java.util.HashSet<Integer> c1, java.util.HashSet<Integer> c2, java.util.HashMap<Integer, Integer> d1, java.util.HashMap<Integer, Integer> d2, int e1, long e2, String e3, int f1, long f2, String f3, cfg.test.RefDynamicBase s1 ) {
        this.id = id;
        this.x1 = x1;
        this.x12 = x1_2;
        this.x2 = x2;
        this.x3 = x3;
        this.x4 = x4;
        this.a1 = a1;
        this.a2 = a2;
        this.b1 = b1;
        this.b2 = b2;
        this.c1 = c1;
        this.c2 = c2;
        this.d1 = d1;
        this.d2 = d2;
        this.e1 = e1;
        this.e2 = e2;
        this.e3 = e3;
        this.f1 = f1;
        this.f2 = f2;
        this.f3 = f3;
        this.s1 = s1;
    }

    public static TestRef deserializeTestRef(JsonObject __json__) {
        return new TestRef(__json__);
    }

    public final int id;
    public final int x1;
    public cfg.test.TestBeRef x1_Ref;
    public final int x12;
    public final int x2;
    public final int x3;
    public final int x4;
    public cfg.tag.TestTag x4_Ref;
    public final int[] a1;
    public cfg.test.TestBeRef[] a1_Ref;
    public final int[] a2;
    public cfg.test.TestBeRef[] a2_Ref;
    public final java.util.ArrayList<Integer> b1;
    public java.util.ArrayList<cfg.test.TestBeRef> b1_Ref;
    public final java.util.ArrayList<Integer> b2;
    public java.util.ArrayList<cfg.test.TestBeRef> b2_Ref;
    public final java.util.HashSet<Integer> c1;
    public java.util.HashSet<cfg.test.TestBeRef> c1_Ref;
    public final java.util.HashSet<Integer> c2;
    public java.util.HashSet<cfg.test.TestBeRef> c2_Ref;
    public final java.util.HashMap<Integer, Integer> d1;
    public java.util.HashMap<Integer, cfg.test.TestBeRef> d1_Ref;
    public final java.util.HashMap<Integer, Integer> d2;
    public java.util.HashMap<Integer, cfg.test.TestBeRef> d2_Ref;
    public final int e1;
    public final long e2;
    public final String e3;
    public final int f1;
    public final long f2;
    public final String f3;
    public final cfg.test.RefDynamicBase s1;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        this.x1_Ref = ((cfg.test.TbTestBeRef)_tables.get("test.TbTestBeRef")).get(x1);
        this.x4_Ref = ((cfg.tag.TbTestTag)_tables.get("tag.TbTestTag")).get(x4);
        { int __n = a1.length; cfg.test.TbTestBeRef __table = (cfg.test.TbTestBeRef)_tables.get("test.TbTestBeRef"); this.a1_Ref = new cfg.test.TestBeRef[__n]; for(int i = 0 ; i < __n ; i++) { this.a1_Ref[i] =  __table.get(a1[i]); } }
        { int __n = a2.length; cfg.test.TbTestBeRef __table = (cfg.test.TbTestBeRef)_tables.get("test.TbTestBeRef"); this.a2_Ref = new cfg.test.TestBeRef[__n]; for(int i = 0 ; i < __n ; i++) { this.a2_Ref[i] =  __table.get(a2[i]); } }
        { cfg.test.TbTestBeRef __table = (cfg.test.TbTestBeRef)_tables.get("test.TbTestBeRef"); this.b1_Ref = new java.util.ArrayList<cfg.test.TestBeRef>(); for(int __e : b1) { this.b1_Ref.add(__table.get(__e)); } }
        { cfg.test.TbTestBeRef __table = (cfg.test.TbTestBeRef)_tables.get("test.TbTestBeRef"); this.b2_Ref = new java.util.ArrayList<cfg.test.TestBeRef>(); for(int __e : b2) { this.b2_Ref.add(__table.get(__e)); } }
        { cfg.test.TbTestBeRef __table = (cfg.test.TbTestBeRef)_tables.get("test.TbTestBeRef"); this.c1_Ref = new java.util.HashSet<cfg.test.TestBeRef>(); for(int __e : c1) { this.c1_Ref.add(__table.get(__e)); } }
        { cfg.test.TbTestBeRef __table = (cfg.test.TbTestBeRef)_tables.get("test.TbTestBeRef"); this.c2_Ref = new java.util.HashSet<cfg.test.TestBeRef>(); for(int __e : c2) { this.c2_Ref.add(__table.get(__e)); } }
        { cfg.test.TbTestBeRef __table = (cfg.test.TbTestBeRef)_tables.get("test.TbTestBeRef"); this.d1_Ref = new java.util.HashMap<Integer, cfg.test.TestBeRef>(); for(java.util.Map.Entry<Integer, Integer> __e : d1.entrySet()) { int __eKey = __e.getKey(); int __eValue = __e.getValue(); this.d1_Ref.put(__eKey, __table.get(__eValue)); } }
        { cfg.test.TbTestBeRef __table = (cfg.test.TbTestBeRef)_tables.get("test.TbTestBeRef"); this.d2_Ref = new java.util.HashMap<Integer, cfg.test.TestBeRef>(); for(java.util.Map.Entry<Integer, Integer> __e : d2.entrySet()) { int __eKey = __e.getKey(); int __eValue = __e.getValue(); this.d2_Ref.put(__eKey, __table.get(__eValue)); } }
        if (s1 != null) {s1.resolve(_tables);}
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "x1:" + x1 + ","
        + "x12:" + x12 + ","
        + "x2:" + x2 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "a1:" + a1 + ","
        + "a2:" + a2 + ","
        + "b1:" + b1 + ","
        + "b2:" + b2 + ","
        + "c1:" + c1 + ","
        + "c2:" + c2 + ","
        + "d1:" + d1 + ","
        + "d2:" + d2 + ","
        + "e1:" + e1 + ","
        + "e2:" + e2 + ","
        + "e3:" + e3 + ","
        + "f1:" + f1 + ","
        + "f2:" + f2 + ","
        + "f3:" + f3 + ","
        + "s1:" + s1 + ","
        + "}";
    }
}
