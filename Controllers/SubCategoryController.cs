using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureCityBE.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class SubCategoryController: ControllerBase
{
    private readonly FurnitureStoreDb _dbContext;
    private readonly GenericRepository<SubCategory> _repository;
    
    public SubCategoryController(FurnitureStoreDb dbContext)
    {
        _dbContext = dbContext;
        _repository = new GenericRepository<SubCategory>(dbContext);
    }
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<SubCategory>>> Index()
    {
        return Ok(await _repository.GetAll());
    }

    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<object>> Create(SubCategory subCategory)
    {
        _repository.Add(subCategory);
        await _repository.Savechange();
        return Ok(subCategory);
    }

    [HttpGet]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<SubCategory>> Get(Guid id)
    {
        return Ok(await _repository.GetById(id));
    }
}
