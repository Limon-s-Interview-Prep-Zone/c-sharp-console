namespace Multithreading;

internal static class TaskBasedThreadPool
{
    internal static async Task ExecuteThreadAsync()
    {
        Console.WriteLine("Order Processing System Started.");

        // Simulate receiving 5 new orders to be processed concurrently
        Task[] orderTasks = new Task[2];
        for (int i = 1; i <= 2; i++)
        {
            int orderId = i;
            // Process each order asynchronously
            orderTasks[i - 1] = ProcessOrderAsync(orderId);
        }

        // Wait for all the order processing tasks to complete
        await Task.WhenAll(orderTasks);

        Console.WriteLine("All orders processed.");
        Console.WriteLine("Order Processing System Stopped.");
    }

    // Async method to process each order
    static async Task ProcessOrderAsync(int orderId)
    {
        Console.WriteLine($"Task started to process order {orderId}");

        // Simulate updating inventory
        await UpdateInventoryAsync(orderId);

        // Simulate sending a confirmation email
        await SendConfirmationEmailAsync(orderId);

        // Simulate generating an invoice
        await GenerateInvoiceAsync(orderId);

        Console.WriteLine($"Order {orderId} processed successfully.");
    }

    static async Task UpdateInventoryAsync(int orderId)
    {
        Console.WriteLine($"Updating inventory for order {orderId}...");
        await Task.Delay(1000);  // Simulating time delay
        Console.WriteLine($"Inventory updated for order {orderId}.");
    }

    static async Task SendConfirmationEmailAsync(int orderId)
    {
        Console.WriteLine($"Sending confirmation email for order {orderId}...");
        await Task.Delay(500);  // Simulating time delay
        Console.WriteLine($"Confirmation email sent for order {orderId}.");
    }

    static async Task GenerateInvoiceAsync(int orderId)
    {
        Console.WriteLine($"Generating invoice for order {orderId}...");
        await Task.Delay(1500);  // Simulating time delay
        Console.WriteLine($"Invoice generated for order {orderId}.");
    }
}