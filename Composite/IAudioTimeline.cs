using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface IAudioTimeline
    {
        TimeSpan StartTime { get; }
        TimeSpan EndTime { get; }
        IEnumerable<TimeSpan> Cuts { get; }

        IEnumerable<string> ToOutputLines();

    }
}
