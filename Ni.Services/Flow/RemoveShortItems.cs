using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using NI.Core.Domain;
using NI.Core.Flow;

namespace Ni.Services.Flow
{
    public class RemoveShortItemsStep: IAnalyzeFlowStep
    {
        private const int MinLength = 5;

        public IEnumerable<SearchItem> Execute(IEnumerable<SearchItem> source)
        {
            source = source ?? throw new ArgumentNullException(nameof(source));

            return source.Where(x => x.Text.Length >= MinLength);
        }
    }
}
