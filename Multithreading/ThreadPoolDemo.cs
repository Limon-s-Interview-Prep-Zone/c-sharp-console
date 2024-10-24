namespace Multithreading;

internal static class ThreadPoolDemo
{
    internal static void ExecuteThread()
    {
        Console.WriteLine("Order Processing System Started.");

        // Simulate receiving 5 new orders to be processed concurrently
        for (int i = 1; i <= 2; i++)
        {
            int orderId = i;
            // Queue the order processing to the ThreadPool
            ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessOrder), orderId);
        }

        // Main thread is free to perform other tasks, e.g., handling more orders
        Console.WriteLine("Main thread is free to handle other requests.");

        // Simulate the system running by keeping the main thread alive for a while
        Thread.Sleep(6000);
        Console.WriteLine("Order Processing System Stopped.");
    }

    // Method to process each order
    private static void ProcessOrder(object state)
    {
        int orderId = (int) state;

        Console.WriteLine($"Thread started to process order {orderId}");

        // Simulate updating inventory
        UpdateInventory(orderId);

        // Simulate sending a confirmation email
        SendConfirmationEmail(orderId);

        // Simulate generating an invoice
        GenerateInvoice(orderId);

        Console.WriteLine($"Order {orderId} processed successfully.");
    }

    private static void UpdateInventory(int orderId)
    {
        Console.WriteLine($"Updating inventory for order {orderId}...");
        Thread.Sleep(1000); // Simulating time delay
        Console.WriteLine($"Inventory updated for order {orderId}.");
    }

    private static void SendConfirmationEmail(int orderId)
    {
        Console.WriteLine($"Sending confirmation email for order {orderId}...");
        Thread.Sleep(500); // Simulating time delay
        Console.WriteLine($"Confirmation email sent for order {orderId}.");
    }

    private static void GenerateInvoice(int orderId)
    {
        Console.WriteLine($"Generating invoice for order {orderId}...");
        Thread.Sleep(1500); // Simulating time delay
        Console.WriteLine($"Invoice generated for order {orderId}.");
    }
}