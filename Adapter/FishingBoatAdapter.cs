using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FishingBoatAdapter : IRowingBoat
    {
        private FishingBoat fishingBoat;

        public FishingBoatAdapter()
        {
            fishingBoat = new FishingBoat();
        }
        public void Row()
        {
            fishingBoat.Sail();
        }
    }
}
