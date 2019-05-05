using System.Collections.Generic;
using System.Linq;

namespace TSDB
{
    public class SampleStorage : ISampleStorage
    {
        private readonly Dictionary<ulong, List<Sample>> _series = new Dictionary<ulong, List<Sample>>();

        public bool Exists(ulong hash)
        {
            return _series.ContainsKey(hash);
        }

        public List<Sample> Get(long startTimestamp, long endTimestamp, ulong hash)
        {
            return _series[hash]
                .Where(sample => sample.Timestamp >= startTimestamp && sample.Timestamp <= endTimestamp)
                .ToList();
        }

        public void Insert(ulong hash, List<Sample> samples)
        {
            if (!_series.TryGetValue(hash, out var series))
            {
                series = new List<Sample>();
                _series.Add(hash, series);
            }

            series.AddRange(samples);
        }
    }
}
