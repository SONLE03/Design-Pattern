using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class SubtitleService
    {
        public void DisplaySubtitle(string subtitle)
        {
            Console.WriteLine($"Displaying subtitle: {subtitle}");
        }
    }
}
