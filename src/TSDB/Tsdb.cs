using System.Collections.Generic;

namespace TSDB
{
    public class Tsdb : ITsdb

    {
        private readonly IIndex _index;
        private readonly ISampleStorage _sampleStorage;
        private readonly IWalAppender _walAppender;

        public Tsdb(IIndex index, ISampleStorage sampleStorage, IWalAppender walAppender)
        {
            _index = index;
            _sampleStorage = sampleStorage;
            _walAppender = walAppender;
        }

        public void Insert(TimeSeries timeSeries)
        {
        }

        public QueryResult Query(Query query)
        {
            return new QueryResult();
        }

        private ulong CalculateHash(List<Label> labels)
        {
            ulong hash = 0;

            labels.ForEach(label => hash ^= (uint)label.Name.GetHashCode() << 32 ^ (uint)label.Value.GetHashCode());

            return hash;
        }
    }
}
