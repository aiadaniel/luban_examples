//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.ai;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class IsSet extends cfg.ai.KeyQueryOperator {
    public IsSet(JsonObject __json__) { 
        super(__json__);
    }

    public IsSet() {
        super();
    }

    public static IsSet deserializeIsSet(JsonObject __json__) {
        return new IsSet(__json__);
    }


    public static final int __ID__ = 1635350898;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "}";
    }
}
