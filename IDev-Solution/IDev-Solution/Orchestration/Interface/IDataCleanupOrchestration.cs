using System.Collections.Generic;

namespace Hackathon.Orchestration.Interface
{
    public interface IDataCleanupOrchestration
    {
        List<string> CleanAndLoad();
    }
}
