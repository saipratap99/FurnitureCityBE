using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureCityBE.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController:  ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Index()
        {
            return Ok(await _categoryRepository.GetAllCategoriesAsync());
        }

        [HttpPost]
        [Route("[Action]")]
        public async Task<ActionResult<object>> Create(Category category)
        {
            return Ok(await _categoryRepository.CreateCategoryAsync(category));
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public async Task<ActionResult<Category>> Get(Guid id)
        {
            return Ok(await _categoryRepository.GetCategoryByIdAsync(id));
        }
    }
}
