using backend.Data;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController(ProductService productService):ControllerBase
{

    [HttpGet]
    public async Task<List<Product>> GetAll()
    {
        return await productService.GetAllProducts();
    }

    [HttpPost]
    public async Task<Product> Add([FromBody] Product product)
    {
        return await productService.AddAsync(product);
    }
    
    [HttpGet("{id}")]
    public async Task<Product?> GetById(int id)
    {
        return await productService.GetByIdAsync(id);
    }
    
    
}