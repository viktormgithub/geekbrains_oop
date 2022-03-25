namespace Lesson002Task004
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
            BankAccount account3 = new BankAccount(AccountTypesEnum.CheckingAccount);
            BankAccount account4 = new BankAccount(-5000, AccountTypesEnum.DepositAccount);
            
            Console.WriteLine("--- Cчет #1 ---");
            Console.WriteLine($"Номер счета: {account1.AccountId}");
            Console.WriteLine($"Баланс: {account1.Balance}");
            Console.WriteLine($"Тип счета: {account1.AccountType}");

            Console.WriteLine("--- Cчет #2 ---");
            Console.WriteLine($"Номер счета: {account2.AccountId}");
            Console.WriteLine($"Баланс: {account2.Balance}");
            Console.WriteLine($"Тип счета: {account2.AccountType}");

            Console.WriteLine("--- Cчет #3 ---");
            Console.WriteLine($"Номер счета: {account3.AccountId}");
            Console.WriteLine($"Баланс: {account3.Balance}");
            Console.WriteLine($"Тип счета: {account3.AccountType}");

            Console.WriteLine("--- Cчет #4 ---");
            Console.WriteLine($"Номер счета: {account4.AccountId}");
            Console.WriteLine($"Баланс: {account4.Balance}");
            Console.WriteLine($"Тип счета: {account4.AccountType}");
        }
    }

    public class BankAccount
    {
        private int _balance;
        public string AccountId { get; }
        public int Balance
        {
            get => _balance;
            private set
            {
                _balance = value switch
                {
                    < 0 => 0,
                    >= 0 => value
                };
            }
        }
        public AccountTypesEnum AccountType { get; set; }


        public BankAccount()
        {
            AccountId = GenerateAccountId();
            AccountType = AccountTypesEnum.CurrentAccount;
            Balance = 0;
        }

        public BankAccount(int balance) : this()
        {
            Balance = balance;
        }

        public BankAccount(AccountTypesEnum accountType) : this()
        {
            AccountType = accountType;
        }


        public BankAccount(int balance, AccountTypesEnum accountType) : this()
        {
            Balance = balance;
            AccountType = accountType;
        }

        private string GenerateAccountId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}