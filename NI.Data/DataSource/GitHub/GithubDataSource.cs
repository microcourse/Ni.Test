using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NI.Core.Data;
using NI.Core.Domain;
using Refit;

namespace NI.Data.DataSource.GitHub
{
    public class GithubDataSource : IDataSource
    {
        private const string Endpoint = "https://api.github.com";
        public async Task<IReadOnlyCollection<SearchItem>> FetchAsync()
        {
            var client = RestService.For<IGitHubApi>(Endpoint);
            var items = await client.FetchAsync();
            var result = items.Select(x => new SearchItem
            {
                Text = x.Commit.Message
            }).ToArray();


            return result;
        }
    }
}