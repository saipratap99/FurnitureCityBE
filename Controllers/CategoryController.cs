using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurnitureCityBE.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
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
            return Ok(await _repository.GetAll());
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
        public async Task<ActionResult<Category>> Get(Guid subcategory_id)
        {
            return Ok(await _repository.GetById(subcategory_id));
        }

        // New method to get subcategories by category ID using the mapping
        [HttpGet]
        [Route("GetSubcategories/{categoryName}")]
        public async Task<ActionResult<List<SubCategory>>> GetSubcategories(string categoryName)
        {
         
            // Fetch the category by its name
            var category = await _dbContext.Categories
                .FirstOrDefaultAsync(c => c.Name == categoryName);
           // Console.WriteLine(categoryName);
           Console.WriteLine(category);
            if (category == null)
            {
                return NotFound("Category not found.");
            }

            // Fetch subcategory mappings for the category
            var subcategoryMappings = await _dbContext.CategorySubCategoryMappings
                .Where(mapping => mapping.CategoryId == category.Id)
                .Include(mapping => mapping.SubCategory)
                .ToListAsync();

            if (subcategoryMappings == null || !subcategoryMappings.Any())
            {
                return NotFound("No subcategories found for the given category.");
            }

            var subcategories = subcategoryMappings.Select(mapping => mapping.SubCategory).ToList();
            return Ok(subcategories);
        }

    }
}
