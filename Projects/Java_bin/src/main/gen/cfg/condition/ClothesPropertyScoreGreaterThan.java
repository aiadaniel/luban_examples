//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.condition;

import bright.serialization.*;



public final class ClothesPropertyScoreGreaterThan extends cfg.condition.BoolRoleCondition {
    public ClothesPropertyScoreGreaterThan(ByteBuf _buf) { 
        super(_buf);
        prop = _buf.readInt();
        value = _buf.readInt();
    }

    public ClothesPropertyScoreGreaterThan(int prop, int value ) {
        super();
        this.prop = prop;
        this.value = value;
    }


    public final int prop;
    public final int value;

    public static final int __ID__ = 696630835;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "prop:" + prop + ","
        + "value:" + value + ","
        + "}";
    }
}
