
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
    public partial class DemoD3 : AConfig
    {
        [JsonProperty("x3")]
        private int _x3 { get; set; }
        [JsonIgnore]
        public EncryptInt x3 { get; private set; } = new();


        public override void EndInit() 
        {
            x3 = _x3;
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
