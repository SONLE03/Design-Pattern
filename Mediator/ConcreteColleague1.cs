using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public override void NotifyColleague(string message)
        {
            this.mediator.NotifyColleague(this, message);
        }

        public override void Receive(string message)
        {
            this.SetReceivedMessage(message);
        }
    }
}
