using backend.Data;
using backend.Models;
using backend.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend.Services;

public class ProductService(ProductRepo repo)
{
    
    public async Task<List<Product>> GetAllProducts()
    {
        return await repo.GetAllAsync();
    }

    public async Task<Product> AddAsync(Product product)
    {
        return await repo.AddAsync(product);
    }
    
    public async Task<Product?> GetByIdAsync(int id)
    {
        return await repo.GetByIdAsync(id);
    }
    
     
    
}