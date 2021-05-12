using System;
using System.Text;

namespace NI.Core.Flow
{
    public interface IAnalyzeFlowFactory
    {
        IAnalyzeFlow Create(long flowId);
    }
}
