//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.blueprint;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class NormalClazz extends cfg.blueprint.Clazz {
    public NormalClazz(JsonObject __json__) { 
        super(__json__);
        isAbstract = __json__.get("is_abstract").getAsBoolean();
        { com.google.gson.JsonArray _json0_ = __json__.get("fields").getAsJsonArray(); fields = new java.util.ArrayList<cfg.blueprint.Field>(_json0_.size()); for(JsonElement _e0 : _json0_) { cfg.blueprint.Field _v0;  _v0 = new cfg.blueprint.Field(_e0.getAsJsonObject());  fields.add(_v0); }   }
    }

    public NormalClazz(String name, String desc, java.util.ArrayList<cfg.blueprint.Clazz> parents, java.util.ArrayList<cfg.blueprint.Method> methods, boolean is_abstract, java.util.ArrayList<cfg.blueprint.Field> fields ) {
        super(name, desc, parents, methods);
        this.isAbstract = is_abstract;
        this.fields = fields;
    }

    public static NormalClazz deserializeNormalClazz(JsonObject __json__) {
        return new NormalClazz(__json__);
    }

    public final boolean isAbstract;
    public final java.util.ArrayList<cfg.blueprint.Field> fields;

    public static final int __ID__ = -2073576778;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        for(cfg.blueprint.Field _e : fields) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "name:" + name + ","
        + "desc:" + desc + ","
        + "parents:" + parents + ","
        + "methods:" + methods + ","
        + "isAbstract:" + isAbstract + ","
        + "fields:" + fields + ","
        + "}";
    }
}
