using System.Collections.Generic;

namespace TSDB
{
    public class SampleStorage : ISampleStorage
    {
        public bool Exists(long hash)
        {
            return false;
        }

        public List<Sample> Get(long startTimestamp, long endTimestamp, long hash)
        {
            return new List<Sample>();
        }

        public void Insert(long hash, List<Sample> samples)
        {
        }
    }
}
