//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;



public final class MultiUnionIndexList {
    public MultiUnionIndexList(ByteBuf _buf) { 
        id1 = _buf.readInt();
        id2 = _buf.readLong();
        id3 = _buf.readString();
        num = _buf.readInt();
        desc = _buf.readString();
    }

    public MultiUnionIndexList(int id1, long id2, String id3, int num, String desc ) {
        this.id1 = id1;
        this.id2 = id2;
        this.id3 = id3;
        this.num = num;
        this.desc = desc;
    }


    public final int id1;
    public final long id2;
    public final String id3;
    public final int num;
    public final String desc;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id1:" + id1 + ","
        + "id2:" + id2 + ","
        + "id3:" + id3 + ","
        + "num:" + num + ","
        + "desc:" + desc + ","
        + "}";
    }
}
