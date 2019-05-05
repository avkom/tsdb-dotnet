using System.Collections.Generic;

namespace TSDB
{
    public class TimeSeriesMetadata
    {
        public long Hash { get; set; }
        public List<Label> Labels { get; set; }
    }
}
