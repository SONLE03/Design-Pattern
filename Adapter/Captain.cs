using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Captain
    {
        private IRowingBoat rowingBoat;

        public Captain(IRowingBoat rowingBoat)
        {
            this.rowingBoat = rowingBoat;
        }
        public void Row()
        {
            rowingBoat.Row();
        }
    }
}
