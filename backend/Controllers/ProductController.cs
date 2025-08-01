using backend.Data;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController:ControllerBase
{
    private readonly ProductService  _productService;
    
    public ProductController(ProductService  productService) 
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<List<Product>> getAll()
    {
        return await _productService.GetAllProducts();
    }

    [HttpPost]
    public async Task<Product> Add([FromBody] Product product)
    {
        return await _productService.AddAsync(product);
    }
    
    
}