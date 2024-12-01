using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
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
    public async Task<ActionResult<Product>> Create(ProductRequest productDto)
    {
        // var product= new Product{Name = productPayload.Name, IsActive = productPayload.IsActive, Price = (decimal)productPayload.Price, Description = productPayload.Description, Quantity = productPayload.Quantity}
        // _repository.Add(product);
        // await _repository.Savechange();
        

        await using var transaction = await _dbContext.Database.BeginTransactionAsync();

        try
        {
            // Create Product
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = productDto.Name,
                Description = productDto.Description,
                IsActive = productDto.IsActive,
                Quantity = productDto.Quantity,
                Price =(decimal)productDto.Price,
                SubCategoryId = productDto.SubCategoryId,
            };

            _dbContext.Products.Add(product);

            // Add Product Images
            if (productDto.ProductImages != null)
            {
                foreach (var imageUrl in productDto.ProductImages)
                {
                    var productImage = new ProductImage
                    {
                        Id = Guid.NewGuid(),
                        ProductId = product.Id,
                        ImageUrl = imageUrl,
                        AltText = $"{product.Name} image"
                    };
                    _dbContext.ProductImages.Add(productImage);
                }
            }

            // Add Product Tags
            if (productDto.ProductTags != null)
            {
                foreach (var tagId in productDto.ProductTags)
                {
                    var productTagMapping = new ProductTagsMapping
                    {
                        Id = Guid.NewGuid(),
                        ProductId = product.Id,
                        ProductTagId = tagId
                    };
                    _dbContext.ProductTagsMappings.Add(productTagMapping);
                }
            }

            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();

            return Ok("Product created");
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            return StatusCode(500, new { message = "An error occurred while creating the product.", error = ex.Message });
        }
    }

    [HttpPut]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<Product>> Update(Guid id, [FromBody] ProductRequest productDto)
    {
       var existingProduct = await _dbContext.Products
            .Include(p => p.ProductImages)
            .Include(p => p.ProductTagsMappings)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (existingProduct == null)
        {
            return NotFound(new { message = "Product not found." });
        }

        // Begin transaction 
        await using var transaction = await _dbContext.Database.BeginTransactionAsync();

        try
        {
            // Update product details
            existingProduct.Name = productDto.Name;
            existingProduct.Description = productDto.Description;
            existingProduct.IsActive = productDto.IsActive;
            existingProduct.Quantity = productDto.Quantity;
            existingProduct.Price = (decimal)productDto.Price;
            existingProduct.SubCategoryId = productDto.SubCategoryId;

            // Update Product Images
            _dbContext.ProductImages.RemoveRange(existingProduct.ProductImages); // Remove old images
            if (productDto.ProductImages != null)
            {
                foreach (var imageUrl in productDto.ProductImages)
                {
                    var productImage = new ProductImage
                    {
                        Id = Guid.NewGuid(),
                        ProductId = id,
                        ImageUrl = imageUrl,
                        AltText = $"{productDto.Name} image"
                    };
                    _dbContext.ProductImages.Add(productImage);
                }
            }

            // Update Product Tags
            _dbContext.ProductTagsMappings.RemoveRange(existingProduct.ProductTagsMappings); // Remove old tags
            if (productDto.ProductTags != null)
            {
                foreach (var tagId in productDto.ProductTags)
                {
                    var productTagMapping = new ProductTagsMapping
                    {
                        Id = Guid.NewGuid(),
                        ProductId = id,
                        ProductTagId = tagId
                    };
                    _dbContext.ProductTagsMappings.Add(productTagMapping);
                }
            }

            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();

            return Ok("Product updated successfully.");
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            return StatusCode(500, new { message = "An error occurred while updating the product.", error = ex.Message });
        }
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
