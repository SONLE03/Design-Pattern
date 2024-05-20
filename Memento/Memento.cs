using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {

        private int state;

        public Memento(int state)
        {
            this.state = state;
        }

        public int getState()
        {
            return state;
        }
    }
}
