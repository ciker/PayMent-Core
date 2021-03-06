using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffProduceorderBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffProduceorderBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 每页容量：最小1，最大100
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
