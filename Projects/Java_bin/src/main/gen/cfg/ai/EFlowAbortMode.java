
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;
public enum EFlowAbortMode {
    NONE(0),
    LOWER_PRIORITY(1),
    SELF(2),
    BOTH(3),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    EFlowAbortMode(int value) {
        this.value = value;
    }

    public static EFlowAbortMode valueOf(int value) {
        if (value == 0) return NONE;
        if (value == 1) return LOWER_PRIORITY;
        if (value == 2) return SELF;
        if (value == 3) return BOTH;
        throw new IllegalArgumentException("");
    }
}
