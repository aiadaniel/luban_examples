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



public final class MultiRoleCondition extends cfg.condition.RoleCondition {
    public MultiRoleCondition(JsonObject __json__) { 
        super(__json__);
        { com.google.gson.JsonArray _json0_ = __json__.get("conditions").getAsJsonArray(); int __n0 = _json0_.size(); conditions = new cfg.condition.RoleCondition[__n0]; int __index0=0; for(JsonElement __e0 : _json0_) { cfg.condition.RoleCondition __v0;  __v0 = cfg.condition.RoleCondition.deserializeRoleCondition(__e0.getAsJsonObject());  conditions[__index0++] = __v0; }   }
    }

    public MultiRoleCondition(cfg.condition.RoleCondition[] conditions ) {
        super();
        this.conditions = conditions;
    }

    public static MultiRoleCondition deserializeMultiRoleCondition(JsonObject __json__) {
        return new MultiRoleCondition(__json__);
    }

    public final cfg.condition.RoleCondition[] conditions;

    public static final int __ID__ = 934079583;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        for(cfg.condition.RoleCondition _e : conditions) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "conditions:" + conditions + ","
        + "}";
    }
}
