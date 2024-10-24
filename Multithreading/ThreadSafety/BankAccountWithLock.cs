namespace Multithreading.ThreadSafety;

public class BankAccountWithLock
{
    private decimal balance;
    private readonly object balanceLock = new object(); // Lock object for synchronization

    public BankAccountWithLock(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        lock (balanceLock) // Using lock for thread synchronization
        {
            balance += amount;
            Console.WriteLine($"{amount:C} deposited. New balance: {balance:C}");
        }
    }

    public void Withdraw(decimal amount)
    {
        lock (balanceLock)
        {
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn. New balance: {balance:C}");
        }
    }

    public decimal GetBalance()
    {
        lock (balanceLock) // Thread-safe read access
        {
            return balance;
        }
    }
    
    
}

internal static class FactoryMethodForLock
{
    internal static void DriverMethod()
    {
        BankAccountWithLock account = new BankAccountWithLock(1000);

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
