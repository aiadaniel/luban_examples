
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Newtonsoft.Json;
using Scripts;







namespace cfg.test
{
    [Serializable]
    public partial class DemoType2 : AConfig
    {
        [JsonProperty("x4")]
        private int _x4 { get; set; }
        [JsonIgnore]
        public EncryptInt x4 { get; private set; } = new();

        public bool  x1 { get; set; }

        public byte  x2 { get; set; }

        public short  x3 { get; set; }

        [JsonProperty("x5")]
        private long _x5 { get; set; }
        [JsonIgnore]
        public EncryptLong x5 { get; private set; } = new();

        [JsonProperty("x6")]
        private float _x6 { get; set; }
        [JsonIgnore]
        public EncryptFloat x6 { get; private set; } = new();

        [JsonProperty("x7")]
        private double _x7 { get; set; }
        [JsonIgnore]
        public EncryptDouble x7 { get; private set; } = new();

        public short  x8_0 { get; set; }

        public int  x8 { get; set; }

        public long  x9 { get; set; }

        public string  x10 { get; set; }

        [JsonProperty]
        public test.DemoType1  x12 { get; set; }

        public test.DemoEnum  x13 { get; set; }

        [JsonProperty]
        public test.DemoDynamic  x14 { get; set; }

        public string  s1 { get; set; }

        public string S1_l10n_key { get; }
        public System.Numerics.Vector2  v2 { get; set; }

        public System.Numerics.Vector3  v3 { get; set; }

        public System.Numerics.Vector4  v4 { get; set; }

        public int  t1 { get; set; }

        public int[]  k1 { get; set; }

        public System.Collections.Generic.List<int>  k2 { get; set; }

        public System.Collections.Generic.HashSet<int>  k5 { get; set; }

        public System.Collections.Generic.Dictionary<int, int>  k8 { get; set; }

        public System.Collections.Generic.List<test.DemoE2>  k9 { get; set; }

        public test.DemoDynamic[]  k15 { get; set; }


        public override void EndInit() 
        {
            x4 = _x4;
            x5 = _x5;
            x6 = _x6;
            x7 = _x7;
            x12.EndInit();
            x14.EndInit();
            foreach(var _e in k9) { _e.EndInit(); }
            foreach(var _e in k15) { _e.EndInit(); }
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
