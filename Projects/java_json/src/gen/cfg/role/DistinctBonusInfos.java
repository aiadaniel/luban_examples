//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.role;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class DistinctBonusInfos {
    public DistinctBonusInfos(JsonObject __json__) { 
        effectiveLevel = __json__.get("effective_level").getAsInt();
        { com.google.gson.JsonArray _json0_ = __json__.get("bonus_info").getAsJsonArray(); bonusInfo = new java.util.ArrayList<cfg.role.BonusInfo>(_json0_.size()); for(JsonElement __e : _json0_) { cfg.role.BonusInfo __v;  __v = new cfg.role.BonusInfo(__e.getAsJsonObject());  bonusInfo.add(__v); }   }
    }

    public DistinctBonusInfos(int effective_level, java.util.ArrayList<cfg.role.BonusInfo> bonus_info ) {
        this.effectiveLevel = effective_level;
        this.bonusInfo = bonus_info;
    }

    public static DistinctBonusInfos deserializeDistinctBonusInfos(JsonObject __json__) {
        return new DistinctBonusInfos(__json__);
    }

    public final int effectiveLevel;
    public final java.util.ArrayList<cfg.role.BonusInfo> bonusInfo;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.role.BonusInfo _e : bonusInfo) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "effectiveLevel:" + effectiveLevel + ","
        + "bonusInfo:" + bonusInfo + ","
        + "}";
    }
}
