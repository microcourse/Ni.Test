using System;
using System.Collections.Generic;
using System.Text;
using NI.Core.Domain;
using NI.Core.Flow;

namespace Ni.Services.Flow
{
    public class SearchItemAnalyzeFlow: IAnalyzeFlow
    {
        public int Id { get; set; } = 1;

        private ICollection<IAnalyzeFlowStep> steps = new List<IAnalyzeFlowStep>
        {
            new RemoveShortItemsStep(),
            new RemoveSpacesStep()
        };

        public IEnumerable<SearchItem> Execute(IEnumerable<SearchItem> source)
        {
            source = source ?? throw new ArgumentNullException(nameof(source));

            var output = source;

            foreach (var analyzeFlowStep in steps)
            {
                output = analyzeFlowStep.Execute(output);
            }

            return output;
        }
    }
}
