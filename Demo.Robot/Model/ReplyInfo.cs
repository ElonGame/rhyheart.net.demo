using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Demo.Robot.Model
{
    public class ReplyInfo
    {
        /// <summary>
        /// 关键词
        /// </summary>
        [JsonProperty("keyWord")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 回复
        /// </summary>
        [JsonProperty("reply")]
        public string Reply { get; set; }
    }
}
