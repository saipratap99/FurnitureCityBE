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
        var products = await _dbContext.Products .Include(product => product.SubCategory) // Load SubCategory
            .ThenInclude(subCategory => subCategory.CategorySubCategoryMappings) // Load CategorySubCategoryMappings
            .ThenInclude(mapping => mapping.Category) // Load Category
        .Include(product => product.ProductImages) // Load Product Images
        .Include(product => product.ProductTagsMappings) // Load ProductTagsMappings
            .ThenInclude(mapping => mapping.ProductTag) // Load Product Tags
        .Include(product => product.ProductReviews) // Load Product Reviews
        .ToListAsync();

    // Map to DTOs for a clean and structured response
    var productDtos = products.Select(product => new ProductDto
    {
        Id = product.Id,
        Name = product.Name,
        Description = product.Description,
        IsActive = product.IsActive,
        Quantity = product.Quantity,
        Price = product.Price,
        SubCategory = product.SubCategory != null ? new SubCategoryDto
        {
            Id = product.SubCategory.Id,
            Name = product.SubCategory.Name,
            Categories = product.SubCategory.CategorySubCategoryMappings
                .Select(mapping => new CategoryDto
                {
                    Id = mapping.Category.Id,
                    Name = mapping.Category.Name
                }).ToList()
        } : null,
        Images = product.ProductImages.Select(image => new ProductImageDto
        {
            Id = image.Id,
            ImageUrl = image.ImageUrl,
            AltText = image.AltText
        }).ToList(),
        Tags = product.ProductTagsMappings.Select(mapping => new ProductTagDto
        {
            Id = mapping.ProductTag.Id,
            Name = mapping.ProductTag.Name
        }).ToList(),
        Reviews = product.ProductReviews.Select(review => new ProductReviewDto
        {
            Id = review.Id,
            Comments = review.Comments,
            Rating = review.Rating
        }).ToList()
    }).ToList();

    return Ok(productDtos);
    }

    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<Product>> Create(Product product)
    {
        _repository.Add(product);
        await _repository.Savechange();
        return Ok(product);
    }

    [HttpPut]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<Product>> Update(Guid id, Product product)
    {
        var productFound = await _repository.GetById(id);
        if (productFound == null)
            return NotFound("Product not found");
        productFound.Id = id;
        _repository.Edit(product);
        await _repository.Savechange();
        return Ok("Product updated");
    }

    [HttpGet]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<Product>> Get(Guid id)
    {
        return Ok(await _repository.GetById(id));
    }
}
