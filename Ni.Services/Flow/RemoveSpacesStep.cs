using System;
using System.Collections.Generic;
using System.Linq;
using NI.Core.Domain;
using NI.Core.Flow;

namespace Ni.Services.Flow
{
    public class RemoveSpacesStep : IAnalyzeFlowStep
    {
        public IEnumerable<SearchItem> Execute(IEnumerable<SearchItem> source)
        {
            source = source ?? throw new ArgumentNullException(nameof(source));

            return source.Select(x => new SearchItem
            {
                Text = x.Text.Replace(" ", "")
            });
        }
    }
}