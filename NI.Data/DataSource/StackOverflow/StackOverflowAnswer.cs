using System.Text.Json.Serialization;

namespace NI.Data.DataSource.StackOverflow
{
    public class StackOverflowAnswer
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}