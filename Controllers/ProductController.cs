using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurnitureCityBE.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ProductController(FurnitureStoreDb dbContext) : ControllerBase
{
    private readonly FurnitureStoreDb _dbContext = dbContext;
    private readonly GenericRepository<Product> _repository = new(dbContext);

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Product>>> Index()
    {
        return Ok(await _repository.GetAll());
    }

    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<Product>> Create(Product product)
    {
        _repository.Add(product);
        await _repository.Savechange();
        return Ok(product);
    }

    [HttpGet]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<Product>> Get(Guid id)
    {
        return Ok(await _repository.GetById(id));
    }
    
    
    [HttpGet]
    [Route("[Action]/{subCategoryName}")]
    public async Task<ActionResult<List<Product>>> GetBySubCategoryName(string subCategoryName)
    {
        var products = await _dbContext.Products
            .Where(p => p.SubCategory.Name == subCategoryName)
            .ToListAsync();

        if (products == null || !products.Any())
        {
            return NotFound(new { Message = $"No products found for subcategory: {subCategoryName}" });
        }

        return Ok(products);
    }

}
