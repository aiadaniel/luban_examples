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



public final class TestSet {
    public TestSet(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        x0 = __json__.get("x0").getAsString();
        { com.google.gson.JsonArray _json0_ = __json__.get("x1").getAsJsonArray(); x1 = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement __e : _json0_) { int __v;  __v = __e.getAsInt();  x1.add(__v); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("x2").getAsJsonArray(); x2 = new java.util.ArrayList<Long>(_json0_.size()); for(JsonElement __e : _json0_) { long __v;  __v = __e.getAsLong();  x2.add(__v); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("x3").getAsJsonArray(); x3 = new java.util.ArrayList<String>(_json0_.size()); for(JsonElement __e : _json0_) { String __v;  __v = __e.getAsString();  x3.add(__v); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("x4").getAsJsonArray(); x4 = new java.util.ArrayList<cfg.test.DemoEnum>(_json0_.size()); for(JsonElement __e : _json0_) { cfg.test.DemoEnum __v;  __v = cfg.test.DemoEnum.valueOf(__e.getAsInt());  x4.add(__v); }   }
    }

    public TestSet(int id, String x0, java.util.ArrayList<Integer> x1, java.util.ArrayList<Long> x2, java.util.ArrayList<String> x3, java.util.ArrayList<cfg.test.DemoEnum> x4 ) {
        this.id = id;
        this.x0 = x0;
        this.x1 = x1;
        this.x2 = x2;
        this.x3 = x3;
        this.x4 = x4;
    }

    public static TestSet deserializeTestSet(JsonObject __json__) {
        return new TestSet(__json__);
    }

    public final int id;
    public final String x0;
    public final java.util.ArrayList<Integer> x1;
    public final java.util.ArrayList<Long> x2;
    public final java.util.ArrayList<String> x3;
    public final java.util.ArrayList<cfg.test.DemoEnum> x4;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "x0:" + x0 + ","
        + "x1:" + x1 + ","
        + "x2:" + x2 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "}";
    }
}
