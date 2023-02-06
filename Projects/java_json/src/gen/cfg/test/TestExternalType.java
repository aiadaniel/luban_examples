//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class TestExternalType {
    public TestExternalType(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        audioType = __json__.get("audio_type").getAsInt();
        color = new cfg.test.Color(__json__.get("color").getAsJsonObject());
        { com.google.gson.JsonArray _json0_ = __json__.get("audio_types").getAsJsonArray(); audioTypes = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _v0;  _v0 = _e0.getAsInt();  audioTypes.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("colors").getAsJsonArray(); colors = new java.util.ArrayList<cfg.test.Color>(_json0_.size()); for(JsonElement _e0 : _json0_) { cfg.test.Color _v0;  _v0 = new cfg.test.Color(_e0.getAsJsonObject());  colors.add(_v0); }   }
    }

    public TestExternalType(int id, int audio_type, cfg.test.Color color, java.util.ArrayList<Integer> audio_types, java.util.ArrayList<cfg.test.Color> colors ) {
        this.id = id;
        this.audioType = audio_type;
        this.color = color;
        this.audioTypes = audio_types;
        this.colors = colors;
    }

    public static TestExternalType deserializeTestExternalType(JsonObject __json__) {
        return new TestExternalType(__json__);
    }

    public final int id;
    public final int audioType;
    public final cfg.test.Color color;
    public final java.util.ArrayList<Integer> audioTypes;
    public final java.util.ArrayList<cfg.test.Color> colors;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        if (color != null) {color.resolve(_tables);}
        for(cfg.test.Color _e : colors) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "audioType:" + audioType + ","
        + "color:" + color + ","
        + "audioTypes:" + audioTypes + ","
        + "colors:" + colors + ","
        + "}";
    }
}
