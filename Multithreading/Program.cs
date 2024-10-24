// See https://aka.ms/new-console-template for more information

void SingleThread()
{
    Console.WriteLine("Single Thread");
    Console.WriteLine("Task 1: start");
    PerformTask(3000);
    Console.WriteLine("Task 1: End");

    Console.WriteLine("Task 2: Start");
    PerformTask(2000);
    Console.WriteLine("Task 2: End");
    
    Console.WriteLine("End Single Thread");

}

 void PerformTask(int delay)
{
    Thread.Sleep(delay);
}

void MultiThread()
{
    Console.WriteLine("Multi-Thread");

    Thread t1 = new Thread(() => { PerformTaskWithName("Task-1", 5000); });
    Thread t2 = new Thread(() => { PerformTaskWithName("Task-2", 2000); });
    t1.Start();
    t2.Start();
}
void PerformTaskWithName(string taskName, int delay)
{
    Console.WriteLine($"{taskName} started");
    Thread.Sleep(delay);
    Console.WriteLine($"{taskName} ended");
}



SingleThread();
MultiThread();