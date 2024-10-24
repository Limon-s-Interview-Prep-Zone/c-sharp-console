namespace Multithreading.ThreadSafety;

public class BankAccountWithMonitor
{
    private decimal balance;
    private readonly object balanceLock = new object(); // Lock object for synchronization

    public BankAccountWithMonitor(decimal initialBalance)
    {
        balance = initialBalance;
    }

    internal void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        Monitor.Enter(balanceLock); // Monitor for explicit lock management
        try
        {
            balance += amount;
            Console.WriteLine($"{amount:C} deposited. New balance: {balance:C}");
        }
        finally
        {
            Monitor.Exit(balanceLock); // Always release the lock
        }
    }

    internal void Withdraw(decimal amount)
    {
        Monitor.Enter(balanceLock);
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
            Monitor.Exit(balanceLock);
        }
    }

    internal decimal GetBalance()
    {
        Monitor.Enter(balanceLock);
        try
        {
            return balance;
        }
        finally
        {
            Monitor.Exit(balanceLock);
        }
    }
    
    
}

internal static class FactoryMethodWithMonitor
{
    internal static void DriverMethod()
    {
        BankAccountWithMonitor account = new BankAccountWithMonitor(1000);

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
