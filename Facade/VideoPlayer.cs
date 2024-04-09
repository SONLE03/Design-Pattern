using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class VideoPlayer
    {
        public void PlayVideo(string video)
        {
            Console.WriteLine($"Playing video: {video}");
        }
    }
}
