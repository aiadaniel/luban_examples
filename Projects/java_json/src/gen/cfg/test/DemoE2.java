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



public final class DemoE2 {
    public DemoE2(JsonObject __json__) { 
        { if (__json__.has("y1") && !__json__.get("y1").isJsonNull()) { y1 = __json__.get("y1").getAsInt(); } else { y1 = null; } }
        y2 = __json__.get("y2").getAsBoolean();
    }

    public DemoE2(Integer y1, boolean y2 ) {
        this.y1 = y1;
        this.y2 = y2;
    }

    public static DemoE2 deserializeDemoE2(JsonObject __json__) {
        return new DemoE2(__json__);
    }

    public final Integer y1;
    public final boolean y2;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "y1:" + y1 + ","
        + "y2:" + y2 + ","
        + "}";
    }
}
