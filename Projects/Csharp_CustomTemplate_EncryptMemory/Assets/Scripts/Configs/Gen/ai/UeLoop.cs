
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







namespace cfg.ai
{
    [Serializable]
    public partial class UeLoop : AConfig
    {
        [JsonProperty("num_loops")]
        private int _num_loops { get; set; }
        [JsonIgnore]
        public EncryptInt num_loops { get; private set; } = new();

        public bool  infinite_loop { get; set; }

        [JsonProperty("infinite_loop_timeout_time")]
        private float _infinite_loop_timeout_time { get; set; }
        [JsonIgnore]
        public EncryptFloat infinite_loop_timeout_time { get; private set; } = new();


        public override void EndInit() 
        {
            num_loops = _num_loops;
            infinite_loop_timeout_time = _infinite_loop_timeout_time;
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
