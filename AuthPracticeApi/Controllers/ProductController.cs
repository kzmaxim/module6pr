using AuthPracticeApi.Attributes;
using AuthPracticeApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthPracticeApi.Controllers;

[Microsoft.AspNetCore.Components.Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private static readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Ноутбук", Price = 500000 },
        new Product { Id = 2, Name = "Смартфон", Price = 250000 }
    };

    // Задание 2: Защита метода через API Key (X-Api-Key)
    [HttpGet("apikey")]
    [ApiKey]
    public IActionResult GetWithApiKey()
    {
        return Ok(_products);
    }

    // Задание 1 и 5: Защита метода через JWT (Authorization: Bearer)
    [HttpGet]
    [Authorize]
    public IActionResult GetWithJwt()
    {
        return Ok(_products);
    }
}