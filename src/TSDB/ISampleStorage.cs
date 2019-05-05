using System.Collections.Generic;

namespace TSDB
{
    public interface ISampleStorage
    {
        bool Exists(ulong hash);
        void Insert(ulong hash, List<Sample> samples);
        List<Sample> Get(long startTimestamp, long endTimestamp, ulong hash);
    }
}
