//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package proto.test;

import bright.serialization.*;



public final class TestNullable extends bright.serialization.AbstractBean {


    public Integer f1;
    public String f2;
    public proto.test.Simple f3;
    public proto.test.Dyn f4;

    public static final int __ID__ = 0;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void serialize(ByteBuf _buf) { 
        { if (f1 != null){ _buf.writeBool(true); _buf.writeInt(f1); } else { _buf.writeBool(false); } }
        { if (f2 != null){ _buf.writeBool(true); _buf.writeString(f2); } else { _buf.writeBool(false); } }
        { if (f3 != null){ _buf.writeBool(true); proto.test.Simple.serializeSimple(_buf, f3); } else { _buf.writeBool(false); } }
        { if (f4 != null){ _buf.writeBool(true); proto.test.Dyn.serializeDyn(_buf, f4); } else { _buf.writeBool(false); } }
    }

    @Override
    public void deserialize(ByteBuf _buf)
    {
        if(_buf.readBool()){ f1 = _buf.readInt(); } else { f1 = null; }
        if(_buf.readBool()){ f2 = _buf.readString(); } else { f2 = null; }
        if(_buf.readBool()){ f3 = proto.test.Simple.deserializeSimple(_buf); } else { f3 = null; }
        if(_buf.readBool()){ f4 = proto.test.Dyn.deserializeDyn(_buf); } else { f4 = null; }
    }

    public static void serializeTestNullable(ByteBuf _buf, TestNullable v) {
        v.serialize(_buf);
    }

    public static TestNullable deserializeTestNullable(ByteBuf _buf) {
        TestNullable v = new TestNullable();
        v.deserialize(_buf);
        return v;
    }

    @Override
    public String toString() {
        return "{ "
        + "f1:" + f1 + ","
        + "f2:" + f2 + ","
        + "f3:" + f3 + ","
        + "f4:" + f4 + ","
        + "}";
    }
}
