namespace Multithreading;

internal class ThreadSynchronization
{
    private static object _lock = new object();
    private static int _counter = 0;

    static void IncrementCounter()
    {
        lock (_lock)  // Ensures only one thread can enter this block at a time
        {
            _counter++;
            Console.WriteLine($"Counter: {_counter} (Thread ID: {Thread.CurrentThread.ManagedThreadId})");
            Thread.Sleep(500);
        }
    }
    
}