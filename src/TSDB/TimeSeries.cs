﻿using System.Collections.Generic;

namespace TSDB
{
    public class TimeSeries
    {
        public List<Label> Labels { get; set; }
        public List<Sample> Samples { get; set; }
    }
}
