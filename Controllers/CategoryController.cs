using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureCityBE.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController:  ControllerBase
    {
        private readonly FurnitureStoreDb _dbContext;
        private readonly GenericRepository<Category> _categoryRepository;

        public CategoryController(FurnitureStoreDb dbContext)
        {
            _dbContext = dbContext;
            _categoryRepository = new GenericRepository<Category>(dbContext);
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Index()
        {
            return Ok(await _categoryRepository.GetAll());
        }

        [HttpPost]
        [Route("[Action]")]
        public async Task<ActionResult<object>> Create(Category category)
        {
            _categoryRepository.Add(category);
            await _categoryRepository.Savechange();
            return Ok(category);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public async Task<ActionResult<Category>> Get(Guid id)
        {
            
            return Ok(await _categoryRepository.GetById(id));
        }
    }
}
