namespace TaskBasedAsync;

internal static class TaskBasedAsync
{
    internal static void BasicTask()
    {
        Console.WriteLine("\nBasic Task started:");

        // Start a task that prints a message after a delay
        Task task = Task.Run(() =>
        {
            Task.Delay(1000).Wait(); // Simulate a delay
            Console.WriteLine("Task completed!");
        });

        // Do other work on the main thread
        Console.WriteLine("Main thread is running...");
        
        // Wait for the task to complete before exiting the program
        task.Wait();
    }
    
    internal static async Task TaskWhenAll()
    {
        Console.WriteLine("\nTaskWhenAll Started:");

        Task task1 = Task.Delay(2000);
        Task task2 = Task.Delay(3000);
        Task task3 = Task.Delay(1000);

        Console.WriteLine("Waiting for all tasks to complete...");
        await Task.WhenAll(task1, task2, task3);
        Console.WriteLine("All tasks completed!");
    }
    
    internal static void ContinuationTask()
    {
        Console.WriteLine("\nContinuationTask:");

        Task initialTask = Task.Run(() =>
        {
            Console.WriteLine("Starting initial task...");
            Task.Delay(2000).Wait();
            Console.WriteLine("Initial task completed.");
        });

        // Run a continuation task after initial task completes
        Task continuation = initialTask.ContinueWith((t) =>
        {
            Console.WriteLine("Continuation task started.");
        });

        continuation.Wait();
    }

    internal static void ParallelTask()
    {
        Console.WriteLine("\nParallelTask:");
        try
        {
            Parallel.Invoke(
                () => HeavyComputation1(),
                () => HeavyComputation2(),
                () => HeavyComputation3()
            );

            Console.WriteLine("All heavy computations completed.");
        }
        catch (AggregateException ex)
        {
            foreach (var inner in ex.InnerExceptions)
            {
                Console.WriteLine($"Exception: {inner.Message}");
            }
        }
    }
    
    private static void HeavyComputation1()
    {
        Console.WriteLine("HeavyComputation1 started.");
        for (int i = 0; i < 1000000; i++)
        {
        } // Simulate heavy work
        Console.WriteLine("HeavyComputation1 completed.");
    }

    private static void HeavyComputation2()
    {
        Console.WriteLine("HeavyComputation2 started.");
        for (int i = 0; i < 1000000; i++) ; // Simulate heavy work
        Console.WriteLine("HeavyComputation2 completed.");
    }

    private static void HeavyComputation3()
    {
        Console.WriteLine("HeavyComputation3 started.");
        for (int i = 0; i < 1000000; i++) ; // Simulate heavy work
        Console.WriteLine("HeavyComputation3 completed.");
    }
}