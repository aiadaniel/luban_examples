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



public final class DemoE1 extends cfg.test.DemoD3 {
    public DemoE1(JsonObject __json__) { 
        super(__json__);
        x4 = __json__.get("x4").getAsInt();
    }

    public DemoE1(int x1, int x3, int x4 ) {
        super(x1, x3);
        this.x4 = x4;
    }

    public static DemoE1 deserializeDemoE1(JsonObject __json__) {
        return new DemoE1(__json__);
    }

    public final int x4;

    public static final int __ID__ = -2138341717;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "x1:" + x1 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "}";
    }
}
