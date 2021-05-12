using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NI.Core.Data;
using NI.Core.Domain;
using NI.Data.DataSource.GitHub;
using Refit;

namespace NI.Data.DataSource.StackOverflow
{
    public class StackOverflowDataSource : IDataSource
    {
        private const string Endpoint = "https://api.stackexchange.com";

        public async Task<IReadOnlyCollection<SearchItem>> FetchAsync()
        {
            var client = RestService.For<IStackOverflowApi>(Endpoint);

            var response = await client.FetchAsync();
            var result = response.Items.Select(x => new SearchItem
            {
                Text = x.Title
            }).ToArray();

            return result;
        }
    }
}