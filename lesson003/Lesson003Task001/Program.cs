namespace Lesson003Task001
{
    internal class Program
    {
        static void Main()
        {
            BankAccount account1 = new BankAccount(100);
            BankAccount account2 = new BankAccount();

            account2.TransferMoney(account1, 50);

            Console.WriteLine($"acc1: {account1.Balance}");
            Console.WriteLine($"acc2: {account2.Balance}");
        }
    }

    public class BankAccount
    {
        public int Balance { get; private set; }

        public BankAccount()
        {
            Balance = 0;
        }

        public BankAccount(int balance)
        {
            Balance = balance;
        }

        public void TransferMoney(BankAccount accountFrom, int sum)
        {
            accountFrom.Balance -= sum;
            Balance += sum;
        }
    }
}