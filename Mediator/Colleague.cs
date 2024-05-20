using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Colleague
    {
        protected Mediator mediator;
        private string receivedMessage;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void NotifyColleague(string message);

        public abstract void Receive(string message);

        public string GetReceivedMessage()
        {
            return this.receivedMessage;
        }

        public void SetReceivedMessage(string receivedMessage)
        {
            this.receivedMessage = receivedMessage;
        }
    }

}
