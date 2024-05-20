using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Originator
    {

        private int state;

        public void setMemento(Memento memento)
        {
            this.state = memento.getState();
        }

        public Memento createMemento()
        {
            return new Memento(this.state);
        }

        public int getState()
        {
            return state;
        }

        public void setState(int state)
        {
            this.state = state;
        }

    }
}
