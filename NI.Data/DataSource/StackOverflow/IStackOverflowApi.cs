using System.Threading.Tasks;
using Refit;

namespace NI.Data.DataSource.StackOverflow
{
    [Headers("User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.93 Safari/537.36")]
    public interface IStackOverflowApi
    {
        [Get("/2.2/tags/highcharts/faq?site=stackoverflow")]
        Task<StackOverflowItem> FetchAsync();
    }
}
