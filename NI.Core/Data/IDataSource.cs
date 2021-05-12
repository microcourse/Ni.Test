using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NI.Core.Domain;

namespace NI.Core.Data
{
    public interface IDataSource
    {
        Task<IReadOnlyCollection<SearchItem>> FetchAsync();
    }
}
