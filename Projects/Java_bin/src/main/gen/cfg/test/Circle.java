//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;



/**
 * 圆
 */
public final class Circle extends cfg.test.Shape {
    public Circle(ByteBuf _buf) { 
        super(_buf);
        radius = _buf.readFloat();
    }

    public Circle(float radius ) {
        super();
        this.radius = radius;
    }


    /**
     * 半径
     */
    public final float radius;

    public static final int __ID__ = 2131829196;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "radius:" + radius + ","
        + "}";
    }
}
