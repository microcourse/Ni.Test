using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NI.Core.Data;
using NI.Core.Domain;
using NI.Core.Flow;
using NI.Core.Services;

namespace Ni.Services
{
    public class AnalyzeService: IAnalyzeService
    {
        private readonly IDataSourceFactory _dataSourceFactory;
        private readonly IAnalyzeFlowFactory _analyzeFlowFactory;

        public AnalyzeService(
            IDataSourceFactory dataSourceFactory,
            IAnalyzeFlowFactory analyzeFlowFactory)
        {
            this._dataSourceFactory = dataSourceFactory ?? 
                                      throw new ArgumentNullException(nameof(dataSourceFactory));

            this._analyzeFlowFactory = analyzeFlowFactory ??
                                      throw new ArgumentNullException(nameof(analyzeFlowFactory));

        }

        public async Task<string[]> AnalyzeAsync(string dataSourceName)
        {

            var dataSource = _dataSourceFactory.Create(dataSourceName);
            var response = await dataSource.FetchAsync();
            var result = response.Select(x => x.Text).ToArray();

            return result;
        }

        public async Task<string[]> AnalyzeAsync(string dataSourceName, long analysisFlowId)
        {
            var items = await this.AnalyzeAsync(dataSourceName);
            var analyzeFlow = _analyzeFlowFactory.Create(analysisFlowId);
            
            var source = items.Select(x => new SearchItem() {Text = x});
            var output = analyzeFlow.Execute(source);
            var result = output.Select(x => x.Text).ToArray();

            return result;
        }
    }
}
