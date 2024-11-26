using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiCore.Filters;

public class CustomActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        // BEFORE action method execution
        Console.WriteLine("Action Filter: BEFORE action method.");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // AFTER action method execution
        Console.WriteLine("Action Filter: AFTER action method.");
    }
}

// public class AsyncActionFilter : IAsyncActionFilter
// {
//     public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
//     {
//         // Logic BEFORE action method execution
//         Console.WriteLine("Async Action Filter: BEFORE action method.");
//
//         // Call the next delegate/middleware in the pipeline
//         var resultContext = await next();
//
//         // Logic AFTER action method execution
//         Console.WriteLine("Async Action Filter: AFTER action method.");
//     }
// }

public class CacheAsyncActionFilter : ActionFilterAttribute
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        // Logic BEFORE action method execution
        Console.WriteLine("Async Action Filter: BEFORE action method.");

        // Call the next delegate/middleware in the pipeline
        var resultContext = await next();

        // Logic AFTER action method execution
        Console.WriteLine("Async Action Filter: AFTER action method.");
    }
}