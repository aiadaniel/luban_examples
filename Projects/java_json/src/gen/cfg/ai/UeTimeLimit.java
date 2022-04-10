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



public final class UeTimeLimit extends cfg.ai.Decorator {
    public UeTimeLimit(JsonObject __json__) { 
        super(__json__);
        limitTime = __json__.get("limit_time").getAsFloat();
    }

    public UeTimeLimit(int id, String node_name, cfg.ai.EFlowAbortMode flow_abort_mode, float limit_time ) {
        super(id, node_name, flow_abort_mode);
        this.limitTime = limit_time;
    }

    public static UeTimeLimit deserializeUeTimeLimit(JsonObject __json__) {
        return new UeTimeLimit(__json__);
    }

    public final float limitTime;

    public static final int __ID__ = 338469720;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "flowAbortMode:" + flowAbortMode + ","
        + "limitTime:" + limitTime + ","
        + "}";
    }
}
