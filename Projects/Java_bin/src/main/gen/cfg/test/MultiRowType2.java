//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;



public final class MultiRowType2 {
    public MultiRowType2(ByteBuf _buf) { 
        id = _buf.readInt();
        x = _buf.readInt();
        y = _buf.readFloat();
    }

    public MultiRowType2(int id, int x, float y ) {
        this.id = id;
        this.x = x;
        this.y = y;
    }


    public final int id;
    public final int x;
    public final float y;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "x:" + x + ","
        + "y:" + y + ","
        + "}";
    }
}
