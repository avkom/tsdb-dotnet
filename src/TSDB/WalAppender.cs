using System.Collections.Generic;

namespace TSDB
{
    public class WalAppender : IWalAppender
    {
        public void WriteLabels(ulong hash, List<Label> labels)
        {
        }

        public void WriteSamples(ulong hash, List<Sample> samples)
        {
        }
    }
}
