using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiCore.Filters;

public class CustomResultFilter : IResultFilter
{
    public void OnResultExecuting(ResultExecutingContext context)
    {
        // BEFORE result execution
        context.HttpContext.Response.Headers.Add("X-Correlation-ID", Guid.NewGuid().ToString());
        context.HttpContext.Response.Headers.Add("X-Processed-At", DateTime.UtcNow.ToString("o"));
        Console.WriteLine("Result Filter: BEFORE sending response.");
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
        // AFTER result execution
        Console.WriteLine("Result Filter: AFTER sending response.");
    }
}

public class AsyncResultFilter : IAsyncResultFilter
{
    public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    {
        // Logic BEFORE result execution
        Console.WriteLine("Async Result Filter: BEFORE result execution.");

        // Simulating async work
        await Task.Delay(500);

        // Call the next delegate in the pipeline
        var resultContext = await next();

        // Logic AFTER result execution
        Console.WriteLine("Async Result Filter: AFTER result execution.");
    }
}