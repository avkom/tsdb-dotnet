using System.Collections.Generic;

namespace TSDB
{
    public class TimeSeries
    {
        public IList<Label> Labels { get; set; }
        public IList<Sample> Samples { get; set; }
    }
}
