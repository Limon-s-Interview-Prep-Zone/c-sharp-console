namespace Multithreading.ThreadSafety;

public class BankAccountWithMutex
{
    private decimal balance;
    private Mutex mutex = new Mutex(); // Mutex for thread synchronization

    public BankAccountWithMutex(decimal initialBalance)
    {
        balance = initialBalance;
    }

    internal void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        mutex.WaitOne(); // Acquire mutex lock
        try
        {
            balance += amount;
            Console.WriteLine($"{amount:C} deposited. New balance: {balance:C}");
        }
        finally
        {
            mutex.ReleaseMutex(); // Release mutex lock
        }
    }

    internal void Withdraw(decimal amount)
    {
        mutex.WaitOne();
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
            mutex.ReleaseMutex();
        }
    }

    internal decimal GetBalance()
    {
        mutex.WaitOne();
        try
        {
            return balance;
        }
        finally
        {
            mutex.ReleaseMutex();
        }
    }
    
    
}

internal static class FactoryMethodWithMutex
{
    internal static void DriverMethod()
    {
        BankAccountWithMutex account = new BankAccountWithMutex(1000);

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
