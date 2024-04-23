namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NewServerProxy proxy = new NewServerProxy();

            ////Manage orders from a table
            //Console.WriteLine("What would you like to order? ");
            //string order = Console.ReadLine();
            //proxy.TakeOrder(order);
            //Console.WriteLine("Sure thing!  Here's your " + proxy.DeliverOrder() + ".");
            //Console.WriteLine("How would you like to pay?");
            //string payment = Console.ReadLine();
            //proxy.ProcessPayment(payment);

            //Console.ReadKey();
            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            Employee emp1 = new Employee("Anurag", "Anurag123", "Developer");
            SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
            folderProxy1.PerformRWOperations();
            Console.WriteLine();
            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            Employee emp2 = new Employee("Pranaya", "Pranaya123", "Manager");
            SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
            folderProxy2.PerformRWOperations();
            Console.Read();
        
        }
    }
}