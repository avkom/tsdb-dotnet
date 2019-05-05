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
            ulong hash = CalculateHash(timeSeries.Labels);
            _walAppender.WriteSamples(hash, timeSeries.Samples);
            bool hashExists = _sampleStorage.Exists(hash);

            if (!hashExists)
            {
                _walAppender.WriteLabels(hash, timeSeries.Labels);
                _index.Insert(hash, timeSeries.Labels);
            }

            _sampleStorage.Insert(hash, timeSeries.Samples);
        }

        public QueryResult Query(Query query)
        {
            List<TimeSeriesMetadata> metadataList = _index.Query(query.Matchers);
            List<TimeSeries> timeSeriesList = new List<TimeSeries>();

            foreach (TimeSeriesMetadata metadata in metadataList)
            {
                List<Sample> samples =_sampleStorage.Get(query.StartTimestamp, query.EndTimestamp, metadata.Hash);
                TimeSeries timeSeries = new TimeSeries
                {
                    Labels = metadata.Labels,
                    Samples = samples
                };
                timeSeriesList.Add(timeSeries);
            }

            return new QueryResult
            {
                TimeSeries = timeSeriesList
            };
        }

        private ulong CalculateHash(List<Label> labels)
        {
            ulong hash = 0;

            labels.ForEach(label => hash ^= (uint)label.Name.GetHashCode() << 32 ^ (uint)label.Value.GetHashCode());

            return hash;
        }
    }
}
