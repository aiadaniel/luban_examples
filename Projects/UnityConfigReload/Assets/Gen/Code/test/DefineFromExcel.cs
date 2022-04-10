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

public sealed partial class DefineFromExcel :  Bright.Config.BeanBase 
{
    public DefineFromExcel(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X1 = _buf.ReadBool();
        X5 = _buf.ReadLong();
        X6 = _buf.ReadFloat();
        X8 = _buf.ReadInt();
        X10 = _buf.ReadString();
        X13 = (test.ETestQuality)_buf.ReadInt();
        X14 = test.DemoDynamic.DeserializeDemoDynamic(_buf);
        X15 = test.Shape.DeserializeShape(_buf);
        V2 = _buf.ReadUnityVector2();
        T1 = _buf.ReadInt();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K1 = new int[n];for(var i = 0 ; i < n ; i++) { int _e;_e = _buf.ReadInt(); K1[i] = _e;}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K2 = new int[n];for(var i = 0 ; i < n ; i++) { int _e;_e = _buf.ReadInt(); K2[i] = _e;}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K8 = new System.Collections.Generic.Dictionary<int, int>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { int _k;  _k = _buf.ReadInt(); int _v;  _v = _buf.ReadInt();     K8.Add(_k, _v);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K9 = new System.Collections.Generic.List<test.DemoE2>(n);for(var i = 0 ; i < n ; i++) { test.DemoE2 _e;  _e = test.DemoE2.DeserializeDemoE2(_buf); K9.Add(_e);}}
        PostInit();
    }

    public static DefineFromExcel DeserializeDefineFromExcel(ByteBuf _buf)
    {
        return new test.DefineFromExcel(_buf);
    }

    /// <summary>
    /// 这是id
    /// </summary>
    public int Id { get; protected set; }
    /// <summary>
    /// 字段x1
    /// </summary>
    public bool X1 { get; protected set; }
    public long X5 { get; protected set; }
    public float X6 { get; protected set; }
    public int X8 { get; protected set; }
    public string X10 { get; protected set; }
    public test.ETestQuality X13 { get; protected set; }
    public test.DemoDynamic X14 { get; protected set; }
    public test.Shape X15 { get; protected set; }
    public UnityEngine.Vector2 V2 { get; protected set; }
    public int T1 { get; protected set; }
    public long T1_Millis => T1 * 1000L;
    public int[] K1 { get; protected set; }
    public int[] K2 { get; protected set; }
    public System.Collections.Generic.Dictionary<int, int> K8 { get; protected set; }
    public System.Collections.Generic.List<test.DemoE2> K9 { get; protected set; }

    public const int __ID__ = 2100429878;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X14?.Resolve(_tables);
        X15?.Resolve(_tables);
        foreach(var _e in K9) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X14?.TranslateText(translator);
        X15?.TranslateText(translator);
        foreach(var _e in K9) { _e?.TranslateText(translator); }
    }

    public void Reload(DefineFromExcel reloadData)
    {
        Id = reloadData.Id;
        X1 = reloadData.X1;
        X5 = reloadData.X5;
        X6 = reloadData.X6;
        X8 = reloadData.X8;
        X10 = reloadData.X10;
        X13 = reloadData.X13;
        if(X14==null)
        {
            X14 = reloadData.X14;
        }else
        {
            if(X14.GetTypeId() == reloadData.X14.GetTypeId())
            {
                switch (reloadData.X14.GetTypeId())
                {
                    case test.DemoD2.__ID__:
                        (X14 as test.DemoD2).Reload(reloadData.X14 as test.DemoD2);
                        break;
                    case test.DemoE1.__ID__:
                        (X14 as test.DemoE1).Reload(reloadData.X14 as test.DemoE1);
                        break;
                    case test.login.RoleInfo.__ID__:
                        (X14 as test.login.RoleInfo).Reload(reloadData.X14 as test.login.RoleInfo);
                        break;
                    case test.DemoD5.__ID__:
                        (X14 as test.DemoD5).Reload(reloadData.X14 as test.DemoD5);
                        break;
                }
            }else
            {
                typeof(DefineFromExcel).GetProperty("X14").SetValue(this,reloadData.X14);
            }
        }
        if(X15==null)
        {
            X15 = reloadData.X15;
        }else
        {
            if(X15.GetTypeId() == reloadData.X15.GetTypeId())
            {
                switch (reloadData.X15.GetTypeId())
                {
                    case test.Circle.__ID__:
                        (X15 as test.Circle).Reload(reloadData.X15 as test.Circle);
                        break;
                    case test2.Rectangle.__ID__:
                        (X15 as test2.Rectangle).Reload(reloadData.X15 as test2.Rectangle);
                        break;
                }
            }else
            {
                typeof(DefineFromExcel).GetProperty("X15").SetValue(this,reloadData.X15);
            }
        }
        V2 = reloadData.V2;
        T1 = reloadData.T1;
        if(K1==null)
        {
            K1 = reloadData.K1;
        }else
        {
                for(int i = 0; i<reloadData.K1.Length; i++)
                {
                    if(i<K1.Length)
                    {
                        K1[i] = reloadData.K1[i];
                    }
                }
        }
        if(K2==null)
        {
            K2 = reloadData.K2;
        }else
        {
                for(int i = 0; i<reloadData.K2.Length; i++)
                {
                    if(i<K2.Length)
                    {
                        K2[i] = reloadData.K2[i];
                    }
                }
        }
        if(K8==null)
        {
            K8 = reloadData.K8;
        }else
        {
            foreach (var rawDataKey in K8.Keys.ToList())
            {
                if(!reloadData.K8.ContainsKey(rawDataKey))
                {
                    K8.Remove(rawDataKey);
                }
            }
            foreach (var reload in reloadData.K8)
            {
                if(K8.ContainsKey(reload.Key))
                {
                    K8[reload.Key] = reload.Value;
                }else
                {
                    K8.Add(reload.Key,reload.Value);
                }
            }
        }
        if(K9==null)
        {
            K9 = reloadData.K9;
        }else
        {
            K9.Capacity = reloadData.K9.Count;
            for (int i = 0; i < reloadData.K9.Count; i++)
            {
                if(K9[i]!=null)
                {
                    K9[i].Reload(reloadData.K9[i]);
                }else
                {
                    K9[i] = reloadData.K9[i];
                }
            }
        }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "X8:" + X8 + ","
        + "X10:" + X10 + ","
        + "X13:" + X13 + ","
        + "X14:" + X14 + ","
        + "X15:" + X15 + ","
        + "V2:" + V2 + ","
        + "T1:" + T1 + ","
        + "K1:" + Bright.Common.StringUtil.CollectionToString(K1) + ","
        + "K2:" + Bright.Common.StringUtil.CollectionToString(K2) + ","
        + "K8:" + Bright.Common.StringUtil.CollectionToString(K8) + ","
        + "K9:" + Bright.Common.StringUtil.CollectionToString(K9) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
