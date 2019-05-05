using System.Collections.Generic;

namespace TSDB
{
    public class Query
    {
        public long StartTimestamp { get; set; }
        public long EndTimestamp { get; set; }
        public List<LabelMatcher> Matchers { get; set; }
    }
}
