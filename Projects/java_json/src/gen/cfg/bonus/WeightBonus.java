//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.bonus;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class WeightBonus extends cfg.bonus.Bonus {
    public WeightBonus(JsonObject __json__) { 
        super(__json__);
        { com.google.gson.JsonArray _json0_ = __json__.get("bonuses").getAsJsonArray(); int __n0 = _json0_.size(); bonuses = new cfg.bonus.WeightBonusInfo[__n0]; int __index0=0; for(JsonElement __e0 : _json0_) { cfg.bonus.WeightBonusInfo __v0;  __v0 = new cfg.bonus.WeightBonusInfo(__e0.getAsJsonObject());  bonuses[__index0++] = __v0; }   }
    }

    public WeightBonus(cfg.bonus.WeightBonusInfo[] bonuses ) {
        super();
        this.bonuses = bonuses;
    }

    public static WeightBonus deserializeWeightBonus(JsonObject __json__) {
        return new WeightBonus(__json__);
    }

    public final cfg.bonus.WeightBonusInfo[] bonuses;

    public static final int __ID__ = -362807016;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        for(cfg.bonus.WeightBonusInfo _e : bonuses) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "bonuses:" + bonuses + ","
        + "}";
    }
}
