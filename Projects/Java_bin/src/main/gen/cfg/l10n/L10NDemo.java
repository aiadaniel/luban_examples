
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.l10n;

import bright.serialization.*;



public final class L10NDemo {
    public L10NDemo(ByteBuf _buf) { 
        id = _buf.readInt();
        _buf.readString(); text = _buf.readString();
    }

    public L10NDemo(int id, String text ) {
        this.id = id;
        this.text = text;
    }


    public final int id;
    public final String text;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "text:" + text + ","
        + "}";
    }
}
