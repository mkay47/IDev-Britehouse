using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class Order
    {
        [JsonProperty("order_id")]
        public string OrderID { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

    }
}
