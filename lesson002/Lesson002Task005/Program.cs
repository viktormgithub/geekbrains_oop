namespace Lesson002Task005
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
            BankAccount account = new BankAccount(100);
            Console.WriteLine("Открытие счета. Баланс:" + account.Balance);

            account.UpdateBalancePlus(200); 

            Console.WriteLine("Пополнение. Баланс:" + account.Balance);
            
            account.UpdateBalanceMinus(150);
            
            Console.WriteLine("Снятие. Баланс:" + account.Balance);
            
            account.UpdateBalanceMinus(3000);
        }
    }

    public class BankAccount
    {
        public string AccountId { get; }

        public int Balance { get; private set; }

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

        // Пополнить счет
        public void UpdateBalancePlus(int value)
        {
            Balance += value;
        }

        // Снять со счета
        public void UpdateBalanceMinus(int value)
        {
            if (value > Balance)
            {
                Console.WriteLine($"Сумма {value} превышает сумму на снятие. Баланс: {Balance}");
                return;
            }

            Balance -= value;
        }
    }
}