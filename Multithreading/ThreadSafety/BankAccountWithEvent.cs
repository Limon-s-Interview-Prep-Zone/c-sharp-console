namespace Multithreading.ThreadSafety;

public class BankAccountWithEvent
{
    private decimal balance;
    private AutoResetEvent autoResetEvent = new AutoResetEvent(true); // Event to signal thread execution

    public BankAccountWithEvent(decimal initialBalance)
    {
        balance = initialBalance;
    }

    internal void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        autoResetEvent.WaitOne(); // Wait for the signal
        try
        {
            balance += amount;
            Console.WriteLine($"{amount:C} deposited. New balance: {balance:C}");
        }
        finally
        {
            autoResetEvent.Set(); // Signal other threads to proceed
        }
    }

    internal void Withdraw(decimal amount)
    {
        autoResetEvent.WaitOne();
        try
        {
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn. New balance: {balance:C}");
        }
        finally
        {
            autoResetEvent.Set();
        }
    }

    internal decimal GetBalance()
    {
        autoResetEvent.WaitOne();
        try
        {
            return balance;
        }
        finally
        {
            autoResetEvent.Set();
        }
    }
    
    
}

internal static class FactoryMethodWithEvent
{
    internal static void DriverMethod()
    {
        BankAccountWithEvent account = new BankAccountWithEvent(1000);

        Thread t1 = new Thread(() => account.Deposit(200));
        Thread t2 = new Thread(() => account.Deposit(300));
        Thread t3 = new Thread(() => account.Withdraw(150));

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine($"Final balance: {account.GetBalance():C}");
    }
}
