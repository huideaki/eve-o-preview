using System.Collections.Generic;

namespace EveOPreview.Configuration.Implementation
{
    public class CycleClientGroups
    {
        public string CycleGroupName { get; set; } // Only use for config reminder
        public List<string> CycleGroupForwardHotkeys { get; set; }
        public List<string> CycleGroupBackwardHotkeys { get; set; }
        public Dictionary<string, int> CycleGroupClientsOrder { get; set; }
    }
}