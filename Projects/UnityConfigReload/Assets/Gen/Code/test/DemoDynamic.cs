//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.test
{

public abstract partial class DemoDynamic :  Bright.Config.BeanBase 
{
    public DemoDynamic(ByteBuf _buf) 
    {
        X1 = _buf.ReadInt();
        PostInit();
    }

    public static DemoDynamic DeserializeDemoDynamic(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case test.DemoD2.__ID__: return new test.DemoD2(_buf);
            case test.DemoE1.__ID__: return new test.DemoE1(_buf);
            case test.login.RoleInfo.__ID__: return new test.login.RoleInfo(_buf);
            case test.DemoD5.__ID__: return new test.DemoD5(_buf);
            default: throw new SerializationException();
        }
    }

    public int X1 { get; protected set; }


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(DemoDynamic reloadData)
    {
        X1 = reloadData.X1;
    }

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
