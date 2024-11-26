using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiCore.Filters;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        Console.WriteLine("Exception Filter: Exception handled.");
        context.ExceptionHandled = true; // Mark exception as handled
        context.Result = new ObjectResult("An error occurred.")
        {
            StatusCode = 500
        };
    }
}

public class AsyncExceptionFilter : IAsyncExceptionFilter
{
    public async Task OnExceptionAsync(ExceptionContext context)
    {
        // Logic to handle exceptions asynchronously
        Console.WriteLine("Async Exception Filter: Handling exception.");

        // Simulating async work
        await Task.Delay(500);

        context.Result = new ObjectResult("An error occurred.")
        {
            StatusCode = 500
        };
        context.ExceptionHandled = true; // Mark exception as handled
    }
}