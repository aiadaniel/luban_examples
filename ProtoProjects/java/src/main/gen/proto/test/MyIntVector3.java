//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package proto.test;

import bright.serialization.*;



public final class MyIntVector3 extends bright.serialization.AbstractBean {


    public int x;
    public int y;
    public int z;

    public static final int __ID__ = 0;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void serialize(ByteBuf _buf) { 
        _buf.writeInt(x);
        _buf.writeInt(y);
        _buf.writeInt(z);
    }

    @Override
    public void deserialize(ByteBuf _buf)
    {
        x = _buf.readInt();
        y = _buf.readInt();
        z = _buf.readInt();
    }

    public static void serializeMyIntVector3(ByteBuf _buf, MyIntVector3 v) {
        v.serialize(_buf);
    }

    public static MyIntVector3 deserializeMyIntVector3(ByteBuf _buf) {
        MyIntVector3 v = new MyIntVector3();
        v.deserialize(_buf);
        return v;
    }

    @Override
    public String toString() {
        return "{ "
        + "x:" + x + ","
        + "y:" + y + ","
        + "z:" + z + ","
        + "}";
    }
}
