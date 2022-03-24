namespace Lesson002Task003
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
            BankAccount account2 = new BankAccount(220);
            BankAccount account3 = new BankAccount(AccountTypesEnum.CreditAccount);
            BankAccount account4 = new BankAccount(5555, AccountTypesEnum.DepositAccount);

            Console.WriteLine("--- Cчет #1 ---");
            Console.WriteLine($"Номер счета: {account1.GetAccountId()}");
            Console.WriteLine($"Баланс: {account1.GetBalance()}");
            Console.WriteLine($"Тип счета: {account1.GetAccountType()}");

            Console.WriteLine("--- Cчет #2 ---");
            Console.WriteLine($"Номер счета: {account2.GetAccountId()}");
            Console.WriteLine($"Баланс: {account2.GetBalance()}");
            Console.WriteLine($"Тип счета: {account2.GetAccountType()}");

            Console.WriteLine("--- Cчет #3 ---");
            Console.WriteLine($"Номер счета: {account3.GetAccountId()}");
            Console.WriteLine($"Баланс: {account3.GetBalance()}");
            Console.WriteLine($"Тип счета: {account3.GetAccountType()}");

            Console.WriteLine("--- Cчет #4 ---");
            Console.WriteLine($"Номер счета: {account4.GetAccountId()}");
            Console.WriteLine($"Баланс: {account4.GetBalance()}");
            Console.WriteLine($"Тип счета: {account4.GetAccountType()}");
        }
    }

    public class BankAccount
    {
        private readonly string _accountId;
        private readonly int _balance;
        private readonly AccountTypesEnum _accountType;

        public BankAccount()
        {
            _accountId = GenerateAccountId();
            _balance = 0;
            _accountType = AccountTypesEnum.CurrentAccount;
        }

        public BankAccount(int balance) : this()
        {
            _balance = balance;
        }

        public BankAccount(AccountTypesEnum accountType) : this()
        {
            _accountType = accountType;
        }


        public BankAccount(int balance, AccountTypesEnum accountType) : this()
        {
            _balance = balance;
            _accountType = accountType;
        }


        // Читаем поля
        public string GetAccountId()
        {
            return _accountId;
        }

        public int GetBalance()
        {
            return _balance;
        }

        public AccountTypesEnum GetAccountType()
        {
            return _accountType;
        }

        private string GenerateAccountId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}