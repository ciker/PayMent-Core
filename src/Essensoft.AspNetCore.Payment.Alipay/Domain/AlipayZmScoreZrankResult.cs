using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayZmScoreZrankResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayZmScoreZrankResult : AlipayObject
    {
        /// <summary>
        /// 芝麻分分段 Z0-Z7
        /// </summary>
        [JsonProperty("zrank")]
        [XmlElement("zrank")]
        public string Zrank { get; set; }
    }
}
