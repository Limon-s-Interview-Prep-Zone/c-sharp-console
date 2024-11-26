using Microsoft.AspNetCore.Mvc;
using WebApiCore.Entities;
using WebApiCore.Filters;

namespace WebApiCore.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult> GetAsync()
    {
        var product = new Product
        {
            Id = 1,
            Name = "IPhone",
            Price = 150
        };
        return Ok(await Task.FromResult(product));
    }

    [HttpPost]
    [CacheAsyncActionFilter]
    public async Task<ActionResult> PostAsync([FromBody] Product request)
    {
        return Ok(await Task.FromResult(request));
    }
}