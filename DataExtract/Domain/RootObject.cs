using Newtonsoft.Json;

namespace DataExtract.Domain
{
    /// <summary>
    ///     RootObject of the Json Object
    ///     Consists of menu items
    /// </summary>
    public class RootObject
    {
        [JsonProperty(PropertyName = "menu")]
        public Menu menu { get; set; }
    }
}