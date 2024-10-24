// See https://aka.ms/new-console-template for more information
using Multithreading;
using Multithreading.ThreadSafety;

// SingleMultiThread.SingleThread();
// SingleMultiThread.MultiThread();

// MultiThread.ExecuteThread();

// ThreadPoolDemo.ExecuteThread();
// Console.WriteLine("Task-based");
// await TaskBasedThreadPool.ExecuteThreadAsync();


//Synchronization
Console.WriteLine($"Lock Demo:");
FactoryMethodForLock.DriverMethod();

Console.WriteLine($"\nEvent Demo:");
FactoryMethodWithEvent.DriverMethod();

Console.WriteLine($"\nMonitor Demo:");
FactoryMethodWithMonitor.DriverMethod();

Console.WriteLine($"\nMutex Demo:");
FactoryMethodWithMutex.DriverMethod();

Console.WriteLine($"\nThreadSafeList Demo:");
FactoryMethodThreadSafeList.DriverMethod();