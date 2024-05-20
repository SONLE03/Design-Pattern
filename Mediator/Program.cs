namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();

            // Tạo các ConcreteColleague và đăng ký chúng với Mediator
            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            mediator.AddColleague(colleague1);
            mediator.AddColleague(colleague2);

            // Gửi thông điệp từ Colleague1 đến Colleague2 thông qua Mediator
            colleague1.NotifyColleague("Hello from Colleague1!");

            // In ra thông điệp đã nhận được bởi Colleague2
            Console.WriteLine("Message received by Colleague2: " + colleague2.GetReceivedMessage());
        }
    }
}