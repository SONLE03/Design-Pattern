using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteMediator : Mediator
    {
        private List<Colleague> colleagues;

        public ConcreteMediator()
        {
            colleagues = new List<Colleague>();
        }

        public void AddColleague(Colleague colleague)
        {
            colleagues.Add(colleague);
        }

        public void NotifyColleague(Colleague colleague, string message)
        {
            foreach (var receiverColleague in colleagues)
            {
                if (colleague != receiverColleague)
                {
                    receiverColleague.Receive(message);
                }
            }
        }
    }
}
