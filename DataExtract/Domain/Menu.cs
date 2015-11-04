using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataExtract.Domain
{
    /// <summary>
    ///     Menu Iiem
    ///     Each Menu object contains a header and a collection of items
    /// </summary>
    public class Menu
    {
        [JsonProperty(PropertyName = "header")]
        public string header { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<Item> items { get; set; }
    }
}