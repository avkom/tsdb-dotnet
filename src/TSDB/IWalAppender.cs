using System.Collections.Generic;

namespace TSDB
{
    public interface IWalAppender
    {
        void WriteLabels(ulong hash, List<Label> labels);
        void WriteSamples(ulong hash, List<Sample> samples);
    }
}
