using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;

namespace WebApiCore.Filters;

public class CustomResourceFilter : IResourceFilter
{
    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        Console.WriteLine("Resource Filter: Before Model Binding...");
    }

    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        Console.WriteLine("Resource Filter: After Response...");
    }
}

public class AsyncCacheResourceFilter : Attribute, IAsyncResourceFilter
{
    private readonly IMemoryCache _cache;

    public AsyncCacheResourceFilter(IMemoryCache cache)
    {
        _cache = cache;
    }

    public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
    {
        var cacheKey = context.HttpContext.Request.Path;

        // Check if the response is already cached
        if (_cache.TryGetValue(cacheKey, out string cachedResponse))
        {
            // Return cached response
            context.Result = new ContentResult
            {
                Content = cachedResponse,
                ContentType = "application/json"
            };
            return;
        }

        // Proceed to the next filter or action
        var executedContext = await next();

        // Cache the response (if successful)
        if (executedContext.Result is ObjectResult result && result.Value is not null)
        {
            var jsonResponse = JsonSerializer.Serialize(result.Value);
            _cache.Set(cacheKey, jsonResponse, TimeSpan.FromMinutes(5));
        }
    }
}