using Newtonsoft.Json;

namespace DataExtract.Domain
{
    /// <summary>
    ///     Item
    ///     Each item has an id and a label.
    ///     The id is nullable
    /// </summary>
    public class Item
    {
        [JsonProperty(PropertyName = "id")]
        public int? id { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string label { get; set; }
    }
}