namespace Multithreading;

internal static class MultiThread
{
    internal static void ExecuteThread()
    {
        Console.WriteLine("Main thread starting...");

        // Create and start two threads using MethodGroup
        Thread t1 = new Thread(PrintNumbers);
        Thread t2 = new Thread(PrintAlphabets);

        t1.Start();
        t2.Start();

        // Ensure main thread waits for other threads to finish
        t1.Join();
        t2.Join();

        Console.WriteLine("Main thread ending...");
    }
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Number: {i} on Thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(500);  // Simulate work
        }
    }

    static void PrintAlphabets()
    {
        for (char c = 'A'; c <= 'E'; c++)
        {
            Console.WriteLine($"Alphabet: {c} on Thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(700);  // Simulate work
        }
    }
}