using System.Collections.Generic;

namespace TSDB
{
    public class Index : IIndex
    {
        private readonly Dictionary<string, Dictionary<string, SortedSet<ulong>>> _labels = 
            new Dictionary<string, Dictionary<string, SortedSet<ulong>>>();

        public void Insert(ulong hash, List<Label> labels)
        {
            foreach (Label labelToInsert in labels)
            {
                if (!_labels.TryGetValue(labelToInsert.Name, out var label))
                {
                    label = new Dictionary<string, SortedSet<ulong>>();
                    _labels.Add(labelToInsert.Name, label);
                }

                if (!label.TryGetValue(labelToInsert.Value, out var hashes))
                {
                    hashes = new SortedSet<ulong>();
                    label.Add(labelToInsert.Value, hashes);
                }

                hashes.Add(hash);
            }
        }

        public List<TimeSeriesMetadata> Query(List<LabelMatcher> matchers)
        {
            return new List<TimeSeriesMetadata>();
        }
    }
}
