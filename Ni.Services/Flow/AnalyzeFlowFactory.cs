using System;
using System.Collections.Generic;
using System.Text;
using NI.Core.Flow;

namespace Ni.Services.Flow
{
   public class AnalyzeFlowFactory: IAnalyzeFlowFactory
    {
        public IAnalyzeFlow Create(long flowId)
        {

            return flowId == 1 ? new SearchItemAnalyzeFlow() :
                    throw new NotSupportedException();
        }
    }
}
