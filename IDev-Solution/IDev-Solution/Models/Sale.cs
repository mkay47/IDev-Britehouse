using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class Sale
    {
        [JsonProperty("sale_id")]
        public string SaleId { get; set; }

        [JsonProperty("sale_date")]
        public string SaleDate { get; set; }

        [JsonProperty("sale_delivery")]
        public string SaleDelivery { get; set; }
        
    }
}
