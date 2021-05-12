using System.Text.Json.Serialization;

namespace NI.Data.DataSource.StackOverflow
{
    public class StackOverflowItem
    {
        [JsonPropertyName("items")]
        public StackOverflowAnswer[] Items { get; set; }
    }
}