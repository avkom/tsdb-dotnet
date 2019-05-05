using System.Collections.Generic;

namespace TSDB
{
    public class QueryResult
    {
        public IList<TimeSeries> TimeSeries { get; set; }
    }
}
