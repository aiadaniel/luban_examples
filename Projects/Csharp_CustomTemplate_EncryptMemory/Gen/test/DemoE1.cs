
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
    public partial class DemoE1 : AConfig
    {
        [JsonProperty("x4")]
        private int _x4 { get; set; }
        [JsonIgnore]
        public EncryptInt x4 { get; private set; } = new();


        public override void EndInit() 
        {
            x4 = _x4;
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
