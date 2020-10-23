using System;

namespace Banks
{
    public class BankAccount
    {
        private readonly string m_custtomerName;
        private double m_balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_custtomerName = customerName;
            m_balance = balance;
        }

        public string CustomerName { get { return m_custtomerName; } }
        public double Balance { get { return m_balance; } }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount; // Intentionally incorrect code
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Burdett Wilson", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);

            Console.WriteLine($"Current balance is {ba.Balance}");

        }
    }
}
