using System.Text.Json.Serialization;

namespace NI.Data.DataSource.GitHub
{
    public class GitHubItem
    {
        [JsonPropertyName("commit")]
        public GitHubCommit Commit { get; set; }
    }
}