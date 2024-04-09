using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class AudioPlayer
    {
        public void PlayAudio(string audio)
        {
            Console.WriteLine($"Playing audio: {audio}");
        }
    }
}
