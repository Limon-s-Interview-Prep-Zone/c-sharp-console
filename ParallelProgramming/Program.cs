// See https://aka.ms/new-console-template for more information

static void ParallelForEach()
{
    var numbers = new List<int> {1, 2, 3, 4, 5};

    Parallel.ForEach(numbers, number =>
    {
        Console.WriteLine($"Processing {number} on Thread {Task.CurrentId}");
        Task.Delay(500).Wait(); // Simulate work
    });

    Console.WriteLine("Parallel.ForEach loop completed.");
}

static void ParallelFor()
{
    Parallel.For(0, 3, i =>
    {
        Console.WriteLine($"Processing {i} on Thread {Task.CurrentId}");
        // Simulate work
        Task.Delay(500).Wait();
    });

    Console.WriteLine("Parallel.For loop completed.");
}

static void ParallelLINQ()
{
    var numbers = Enumerable.Range(1, 3);

    var squaredNumbers = numbers.AsParallel()
        .Select(number =>
        {
            Console.WriteLine($"Processing {number} on Thread {Task.CurrentId}");
            return number * number;
        })
        .ToList();

    Console.WriteLine("Parallel LINQ completed.");
    squaredNumbers.ForEach(Console.WriteLine);
}

Console.WriteLine("\nParallel.For");
ParallelFor();

Console.WriteLine("\nParallel.ForEach");
ParallelForEach();

Console.WriteLine("\nLINQ");
ParallelLINQ();