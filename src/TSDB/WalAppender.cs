using System.Collections.Generic;

namespace TSDB
{
    public class WalAppender : IWalAppender
    {
        public void WriteLabels(long hash, List<Label> labels)
        {
        }

        public void WriteSamples(long hash, List<Sample> labels)
        {
        }
    }
}
