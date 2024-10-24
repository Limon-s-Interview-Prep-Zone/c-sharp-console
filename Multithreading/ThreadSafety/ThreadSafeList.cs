namespace Multithreading.ThreadSafety;

public class ThreadSafeList<T>
{
    private readonly List<T> internalList = new List<T>();
    private readonly object lockObject = new object(); // Lock object for thread synchronization

    public void Add(T item)
    {
        lock (lockObject) // Synchronize the Add operation
        {
            internalList.Add(item);
            Console.WriteLine($"Item {item} added by thread {Thread.CurrentThread.ManagedThreadId}");
        }
    }

    public bool Remove(T item)
    {
        lock (lockObject) // Synchronize the Remove operation
        {
            return internalList.Remove(item);
        }
    }

    public int Count
    {
        get
        {
            lock (lockObject) // Synchronize the Count operation
            {
                return internalList.Count;
            }
        }
    }

    public List<T> GetAllItems()
    {
        lock (lockObject) // Synchronize access to the entire list
        {
            return new List<T>(internalList); // Return a copy to prevent external modifications
        }
    }
}

internal static class FactoryMethodThreadSafeList
{
    internal static void DriverMethod()
    {
        ThreadSafeList<int> safeList = new ThreadSafeList<int>();

        // Creating multiple threads that modify the list concurrently
        Thread t1 = new Thread(() => safeList.Add(1));
        Thread t2 = new Thread(() => safeList.Add(2));
        Thread t3 = new Thread(() => safeList.Add(3));

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine($"List contains {safeList.Count} items.");
        var items = safeList.GetAllItems();
        Console.WriteLine("Items in list: " + string.Join(", ", items));
    }
}
