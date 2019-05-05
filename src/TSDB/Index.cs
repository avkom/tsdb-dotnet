using System.Collections.Generic;
namespace TSDB
{
    public class Index : IIndex
    {
        private readonly Dictionary<ulong, List<Label>> _labelsByHash = new Dictionary<ulong, List<Label>>();

        //                         LabelName         LabelValue          Hash
        //                             |                  |                |
        private readonly Dictionary<string, Dictionary<string, SortedSet<ulong>>> _hashesByLabel = 
            new Dictionary<string, Dictionary<string, SortedSet<ulong>>>();

        public void Insert(ulong hash, List<Label> labels)
        {
            _labelsByHash.Add(hash, labels);

            foreach (Label labelToInsert in labels)
            {
                if (!_hashesByLabel.TryGetValue(labelToInsert.Name, out var label))
                {
                    label = new Dictionary<string, SortedSet<ulong>>();
                    _hashesByLabel.Add(labelToInsert.Name, label);
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
