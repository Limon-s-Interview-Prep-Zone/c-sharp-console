// See https://aka.ms/new-console-template for more information
using Multithreading;

// SingleMultiThread.SingleThread();
// SingleMultiThread.MultiThread();

// MultiThread.ExecuteThread();

ThreadPoolDemo.ExecuteThread();
Console.WriteLine("Task-based");
await TaskBasedThreadPool.ExecuteThreadAsync();