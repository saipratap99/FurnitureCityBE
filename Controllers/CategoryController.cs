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
        public async Task<ActionResult<Category>> Get(Guid id)
        {
            return Ok(await _repository.GetById(id));
        }
    }
}
