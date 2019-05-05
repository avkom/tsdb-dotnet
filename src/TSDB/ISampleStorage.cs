using System.Collections.Generic;

namespace TSDB
{
    public interface ISampleStorage
    {
        bool Exists(long hash);
        void Insert(long hash, List<Sample> samples);
        List<Sample> Get(long startTimestamp, long endTimestamp, long hash);
    }
}
