using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace NI.Data.DataSource.GitHub
{
    [Headers("User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.93 Safari/537.36")]
    public interface IGitHubApi
    {
        [Get("/repos/highcharts/highcharts/commits")]
        Task<GitHubItem[]> FetchAsync();
    }
}
