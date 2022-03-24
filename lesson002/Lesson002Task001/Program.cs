namespace Lesson002Task001
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

            account1.SetAccountNumber(1234567890);
            account1.SetBalance(3000);
            account1.SetAccountType(3);

            Console.WriteLine("Информация о счете:");
            Console.WriteLine($"Номер счета: {account1.GetAccountNumber()}");
            Console.WriteLine($"Баланс: {account1.GetBalance()}");
            Console.WriteLine($"Тип счета: {account1.GetAccountType()}");
        }
    }

    public class BankAccount
    {
        private int _accountNumber;
        private int _balance;
        private AccountTypesEnum _accountType;

        // Пишем поля
        public void SetAccountNumber(int accountNumber)
        {
            _accountNumber = accountNumber;
        }

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
            return _accountNumber;
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