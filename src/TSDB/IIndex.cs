using System.Collections.Generic;

namespace TSDB
{
    public interface IIndex
    {
        void Insert(ulong hash, List<Label> labels);
        List<TimeSeriesMetadata> Query(List<LabelMatcher> matchers);
    }
}
