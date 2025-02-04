//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.error;

import bright.serialization.*;



public final class ErrorInfo {
    public ErrorInfo(ByteBuf _buf) { 
        code = _buf.readString();
        desc = _buf.readString();
        style = cfg.error.ErrorStyle.deserializeErrorStyle(_buf);
    }

    public ErrorInfo(String code, String desc, cfg.error.ErrorStyle style ) {
        this.code = code;
        this.desc = desc;
        this.style = style;
    }


    public final String code;
    public final String desc;
    public final cfg.error.ErrorStyle style;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        if (style != null) {style.resolve(_tables);}
    }

    @Override
    public String toString() {
        return "{ "
        + "code:" + code + ","
        + "desc:" + desc + ","
        + "style:" + style + ","
        + "}";
    }
}
