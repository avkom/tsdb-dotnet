using System.Collections.Generic;

namespace TSDB
{
    public class Index : IIndex
    {
        public void Insert(long hash, List<Label> labels)
        {
        }

        public List<TimeSeriesMetadata> Query(List<LabelMatcher> matchers)
        {
            return new List<TimeSeriesMetadata>();
        }
    }
}
