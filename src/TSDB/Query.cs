using System.Collections.Generic;

namespace TSDB
{
    public class Query
    {
        public long StartTimestamp { get; set; }
        public long EndTimestamp { get; set; }
        public IList<LabelMatcher> Matchers { get; set; }
    }
}
