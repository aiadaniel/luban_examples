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



public abstract class FlowNode extends cfg.ai.Node {
    public FlowNode(JsonObject __json__) { 
        super(__json__);
        { com.google.gson.JsonArray _json0_ = __json__.get("decorators").getAsJsonArray(); decorators = new java.util.ArrayList<cfg.ai.Decorator>(_json0_.size()); for(JsonElement __e : _json0_) { cfg.ai.Decorator __v;  __v = cfg.ai.Decorator.deserializeDecorator(__e.getAsJsonObject());  decorators.add(__v); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("services").getAsJsonArray(); services = new java.util.ArrayList<cfg.ai.Service>(_json0_.size()); for(JsonElement __e : _json0_) { cfg.ai.Service __v;  __v = cfg.ai.Service.deserializeService(__e.getAsJsonObject());  services.add(__v); }   }
    }

    public FlowNode(int id, String node_name, java.util.ArrayList<cfg.ai.Decorator> decorators, java.util.ArrayList<cfg.ai.Service> services ) {
        super(id, node_name);
        this.decorators = decorators;
        this.services = services;
    }

    public static FlowNode deserializeFlowNode(JsonObject __json__) {
        switch (__json__.get("__type__").getAsString()) {
            case "Sequence": return new cfg.ai.Sequence(__json__);
            case "Selector": return new cfg.ai.Selector(__json__);
            case "SimpleParallel": return new cfg.ai.SimpleParallel(__json__);
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

    public final java.util.ArrayList<cfg.ai.Decorator> decorators;
    public final java.util.ArrayList<cfg.ai.Service> services;


    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        for(cfg.ai.Decorator _e : decorators) { if (_e != null) _e.resolve(_tables); }
        for(cfg.ai.Service _e : services) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "decorators:" + decorators + ","
        + "services:" + services + ","
        + "}";
    }
}
