//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;



public final class TestSep {
    public TestSep(ByteBuf _buf) { 
        id = _buf.readInt();
        _buf.readString(); x1 = _buf.readString();
        x2 = new cfg.test.SepBean1(_buf);
        x3 = new cfg.test.SepVector(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());x4 = new java.util.ArrayList<cfg.test.SepVector>(n);for(int i = 0 ; i < n ; i++) { cfg.test.SepVector _e;  _e = new cfg.test.SepVector(_buf); x4.add(_e);}}
        {int n = Math.min(_buf.readSize(), _buf.size());x5 = new java.util.ArrayList<cfg.test.SepBean1>(n);for(int i = 0 ; i < n ; i++) { cfg.test.SepBean1 _e;  _e = new cfg.test.SepBean1(_buf); x5.add(_e);}}
        {int n = Math.min(_buf.readSize(), _buf.size());x6 = new java.util.ArrayList<cfg.test.SepBean1>(n);for(int i = 0 ; i < n ; i++) { cfg.test.SepBean1 _e;  _e = new cfg.test.SepBean1(_buf); x6.add(_e);}}
    }

    public TestSep(int id, String x1, cfg.test.SepBean1 x2, cfg.test.SepVector x3, java.util.ArrayList<cfg.test.SepVector> x4, java.util.ArrayList<cfg.test.SepBean1> x5, java.util.ArrayList<cfg.test.SepBean1> x6 ) {
        this.id = id;
        this.x1 = x1;
        this.x2 = x2;
        this.x3 = x3;
        this.x4 = x4;
        this.x5 = x5;
        this.x6 = x6;
    }


    public final int id;
    public final String x1;
    public final cfg.test.SepBean1 x2;
    /**
     * SepVector已经定义了sep=,属性
     */
    public final cfg.test.SepVector x3;
    /**
     * 用;来分割数据，然后顺序读入SepVector
     */
    public final java.util.ArrayList<cfg.test.SepVector> x4;
    /**
     * 用,分割数据，然后顺序读入
     */
    public final java.util.ArrayList<cfg.test.SepBean1> x5;
    /**
     * 用;分割数据，然后再将每个数据用,分割，读入
     */
    public final java.util.ArrayList<cfg.test.SepBean1> x6;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        if (x2 != null) {x2.resolve(_tables);}
        if (x3 != null) {x3.resolve(_tables);}
        for(cfg.test.SepVector _e : x4) { if (_e != null) _e.resolve(_tables); }
        for(cfg.test.SepBean1 _e : x5) { if (_e != null) _e.resolve(_tables); }
        for(cfg.test.SepBean1 _e : x6) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "x1:" + x1 + ","
        + "x2:" + x2 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "x5:" + x5 + ","
        + "x6:" + x6 + ","
        + "}";
    }
}
