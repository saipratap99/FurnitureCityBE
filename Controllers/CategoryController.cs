using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurnitureCityBE.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController:  ControllerBase
    {
        private readonly FurnitureStoreDb _dbContext;
        private readonly GenericRepository<Category> _repository;

        public CategoryController(FurnitureStoreDb dbContext)
        {
            _dbContext = dbContext;
            _repository = new GenericRepository<Category>(dbContext);
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Index()
        {
            var categories = await _dbContext.Categories.Include(category => category.CategorySubCategoryMappings) // Load mappings
                .ThenInclude(mapping => mapping.SubCategory) // Load related subcategories
                .ToListAsync();

            // Map to DTOs to prevent circular references and simplify the response
            var categoryDtos = categories.Select(category => new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                SubCategories = category.CategorySubCategoryMappings.Select(mapping => new SubCategoryDto
                {
                    Id = mapping.SubCategory.Id,
                    Name = mapping.SubCategory.Name
                }).ToList()
            }).ToList();

            return Ok(categoryDtos);
        }

        [HttpPost]
        [Route("[Action]")]
        public async Task<ActionResult<object>> Create(Category category)
        {
            _repository.Add(category);
            await _repository.Savechange();
            return Ok(category);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public async Task<ActionResult<Category>> Get(Guid id)
        {
            var category = await _repository.GetById(id);
            if (category == null)
                return NotFound("Category not found");
            return Ok();
        }
        
        [HttpPut]
        [Route("[Action]/{id}")]
        public async Task<ActionResult<Category>> Update(Guid id, Category category)
        {
            var categoryItem = await _repository.GetById(id);
            if (categoryItem == null)
                return NotFound("Category not found");
            categoryItem.Id = id;
            categoryItem.Name = category.Name;
            _repository.Edit(categoryItem);
            await _repository.Savechange();
            return Ok("Category updated");
        }
        
        [HttpDelete]
        [Route("[Action]/{id}")]
        public async Task<ActionResult<Category>> Delete(Guid id)
        {
            var categoryItem = await _repository.GetById(id);
            if (categoryItem == null)
                return NotFound("Category not found");
            _repository.Del(id);
            await _repository.Savechange();
            return Ok("Category Deleted");
        }
    }
}
