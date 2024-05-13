namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount aAccount = new BankAccount();
            BankAccount bAccount = new BankAccount();

            Bank bank = new Bank();

            bank.PerformOperation(new DepositCommand(aAccount, 500));
            bank.PerformOperation(new WithdrawCommand(aAccount, 200));
            bank.PerformOperation(new TransferCommand(aAccount, bAccount, 150));

            Console.ReadKey();
        }
    }
}