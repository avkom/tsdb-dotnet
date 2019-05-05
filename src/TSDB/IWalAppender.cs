using System.Collections.Generic;

namespace TSDB
{
    public interface IWalAppender
    {
        void WriteLabels(long hash, List<Label> labels);
        void WriteSamples(long hash, List<Sample> labels);
    }
}
