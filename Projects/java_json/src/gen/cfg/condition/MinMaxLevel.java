//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.condition;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class MinMaxLevel extends cfg.condition.BoolRoleCondition {
    public MinMaxLevel(JsonObject __json__) { 
        super(__json__);
        minLevel = __json__.get("min_level").getAsInt();
        maxLevel = __json__.get("max_level").getAsInt();
    }

    public MinMaxLevel(int min_level, int max_level ) {
        super();
        this.minLevel = min_level;
        this.maxLevel = max_level;
    }

    public static MinMaxLevel deserializeMinMaxLevel(JsonObject __json__) {
        return new MinMaxLevel(__json__);
    }

    public final int minLevel;
    public final int maxLevel;

    public static final int __ID__ = 907499647;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "minLevel:" + minLevel + ","
        + "maxLevel:" + maxLevel + ","
        + "}";
    }
}
