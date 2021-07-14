using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Models
{
    public class Sprite
    {
        [JsonProperty("front_default")]
        public string Front { get; set; }

        [JsonProperty("back_default")]
        public string Back { get; set; }
    }
}
