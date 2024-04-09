using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class StreamingService
    {
        public void StreamContent(string content)
        {
            Console.WriteLine($"Streaming content: {content}");
        }
    }
}
