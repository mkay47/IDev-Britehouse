using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class Product
    {
        [JsonProperty("Product_id")]
        public string ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("profit")]
        public string Profit { get; set; }
        
        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
