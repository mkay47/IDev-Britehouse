using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class Shipment
    {
        [JsonProperty("shipment_id")]
        public string ShipmentId { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

    }
}
