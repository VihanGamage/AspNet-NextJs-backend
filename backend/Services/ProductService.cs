using backend.Data;
using backend.Models;
using backend.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend.Services;

public class ProductService
{
    private readonly ProductRepo _productRepo;
    
    public ProductService(ProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

    public async Task<List<Product>> GetAllProducts()
    {
        return await _productRepo.GetAllAsync();
    }

    public async Task<Product> AddAsync(Product product)
    {
        return await _productRepo.AddAsync(product);
    }
    
    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _productRepo.GetByIdAsync(id);
    }
    
     
    
}