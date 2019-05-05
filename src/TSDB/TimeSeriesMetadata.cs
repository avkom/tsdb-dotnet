using System.Collections.Generic;

namespace TSDB
{
    public class TimeSeriesMetadata
    {
        public ulong Hash { get; set; }
        public List<Label> Labels { get; set; }
    }
}
