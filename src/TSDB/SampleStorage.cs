using System.Collections.Generic;

namespace TSDB
{
    public class SampleStorage : ISampleStorage
    {
        public bool Exists(ulong hash)
        {
            return false;
        }

        public List<Sample> Get(long startTimestamp, long endTimestamp, ulong hash)
        {
            return new List<Sample>();
        }

        public void Insert(ulong hash, List<Sample> samples)
        {
        }
    }
}
