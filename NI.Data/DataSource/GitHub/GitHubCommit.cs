using System.Text.Json.Serialization;

namespace NI.Data.DataSource.GitHub
{
    public class GitHubCommit
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}