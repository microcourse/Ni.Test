using System.Collections.Generic;
using NI.Core.Domain;

namespace NI.Core.Flow
{
    public interface IAnalyzeFlow
    {
        IEnumerable<SearchItem> Execute(IEnumerable<SearchItem> source);
    }
}