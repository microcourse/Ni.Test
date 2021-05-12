using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NI.Core.Services
{



    public interface IAnalyzeService
    {
        Task<string[]> AnalyzeAsync(string dataSourceName);
        Task<string[]> AnalyzeAsync(string dataSourceName, long analysisFlowId);
    }
}
