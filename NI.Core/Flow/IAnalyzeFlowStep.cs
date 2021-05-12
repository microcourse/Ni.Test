using System.Collections.Generic;
using NI.Core.Domain;

namespace NI.Core.Flow
{
    public interface IAnalyzeFlowStep
    {
        IEnumerable<SearchItem> Execute(IEnumerable<SearchItem> source);
    }
}