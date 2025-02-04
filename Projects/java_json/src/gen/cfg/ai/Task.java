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



public abstract class Task extends cfg.ai.FlowNode {
    public Task(JsonObject __json__) { 
        super(__json__);
        ignoreRestartSelf = __json__.get("ignore_restart_self").getAsBoolean();
    }

    public Task(int id, String node_name, java.util.ArrayList<cfg.ai.Decorator> decorators, java.util.ArrayList<cfg.ai.Service> services, boolean ignore_restart_self ) {
        super(id, node_name, decorators, services);
        this.ignoreRestartSelf = ignore_restart_self;
    }

    public static Task deserializeTask(JsonObject __json__) {
        switch (__json__.get("$type").getAsString()) {
            case "UeWait": return new cfg.ai.UeWait(__json__);
            case "UeWaitBlackboardTime": return new cfg.ai.UeWaitBlackboardTime(__json__);
            case "MoveToTarget": return new cfg.ai.MoveToTarget(__json__);
            case "ChooseSkill": return new cfg.ai.ChooseSkill(__json__);
            case "MoveToRandomLocation": return new cfg.ai.MoveToRandomLocation(__json__);
            case "MoveToLocation": return new cfg.ai.MoveToLocation(__json__);
            case "DebugPrint": return new cfg.ai.DebugPrint(__json__);
            default: throw new bright.serialization.SerializationException();
        }
    }

    public final boolean ignoreRestartSelf;


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
        + "}";
    }
}
