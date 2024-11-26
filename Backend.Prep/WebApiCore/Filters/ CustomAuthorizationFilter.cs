using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiCore.Filters;

public class CustomAuthorizationFilter : IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        // Logic BEFORE proceeding to the rest of the pipeline
        Console.WriteLine("Authorization Filter: Checking authorization...");
        if (context.HttpContext.User.Identity.IsAuthenticated)
            context.Result = new UnauthorizedResult(); // Block request
    }
}

public class AsyncAuthorizationFilter : IAsyncAuthorizationFilter
{
    public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
    {
        // Logic BEFORE authorization
        Console.WriteLine("Async Authorization Filter: Checking authorization...");

        // Simulating async work
        await Task.Delay(500);

        if (!context.HttpContext.User.Identity.IsAuthenticated)
            context.Result = new UnauthorizedResult(); // Block request
    }
}