using System.Collections.Generic;

namespace TSDB
{
    public interface IIndex
    {
        void Insert(long hash, List<Label> labels);
        List<TimeSeriesMetadata> Query(List<LabelMatcher> matchers);
    }
}
