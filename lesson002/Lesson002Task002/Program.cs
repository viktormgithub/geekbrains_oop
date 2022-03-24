namespace Lesson002Task002
{
    public enum AccountTypesEnum
    {
        CurrentAccount, // Текущий счет
        CheckingAccount, // Расчетный счет
        CreditAccount, // Кредитный счет
        DepositAccount // Сберегательный или депозит
    }

    internal class Program
    {
        static void Main()
        {
            BankAccount account1 = new BankAccount();
            
            account1.SetBalance(3000);
            account1.SetAccountType(3);

            Console.WriteLine("Информация о счете 1:");
            Console.WriteLine($"Номер счета 1: {account1.GetAccountNumber()}"); // увеличился +1
            Console.WriteLine($"Баланс 1: {account1.GetBalance()}");
            Console.WriteLine($"Тип счета 1: {account1.GetAccountType()}");

            
            BankAccount account2 = new BankAccount();
            Console.WriteLine($"Номер счета 2: {account2.GetAccountNumber()}"); // увеличился +1

            BankAccount account3 = new BankAccount();
            Console.WriteLine(account3.GetAccountNumber()); // увеличился +1
        }
    }

    public class BankAccount
    {
        private static int _startAccountNumber = 1234567890;

        private int _balance;
        private AccountTypesEnum _accountType;

        // Пишем поля
      

        public void SetBalance(int balance)
        {
            _balance = balance;
        }

        public void SetAccountType(int type)
        {
            _accountType = (AccountTypesEnum) (type);
        }

        // Читаем поля
        public int GetAccountNumber()
        {
            return ++_startAccountNumber;
        }

        public int GetBalance()
        {
            return _balance;
        }

        public AccountTypesEnum GetAccountType()
        {
            return _accountType;
        }
    }
}