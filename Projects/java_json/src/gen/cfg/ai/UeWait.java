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



public final class UeWait extends cfg.ai.Task {
    public UeWait(JsonObject __json__) { 
        super(__json__);
        waitTime = __json__.get("wait_time").getAsFloat();
        randomDeviation = __json__.get("random_deviation").getAsFloat();
    }

    public UeWait(int id, String node_name, java.util.ArrayList<cfg.ai.Decorator> decorators, java.util.ArrayList<cfg.ai.Service> services, boolean ignore_restart_self, float wait_time, float random_deviation ) {
        super(id, node_name, decorators, services, ignore_restart_self);
        this.waitTime = wait_time;
        this.randomDeviation = random_deviation;
    }

    public static UeWait deserializeUeWait(JsonObject __json__) {
        return new UeWait(__json__);
    }

    public final float waitTime;
    public final float randomDeviation;

    public static final int __ID__ = -512994101;

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
        + "decorators:" + decorators + ","
        + "services:" + services + ","
        + "ignoreRestartSelf:" + ignoreRestartSelf + ","
        + "waitTime:" + waitTime + ","
        + "randomDeviation:" + randomDeviation + ","
        + "}";
    }
}
