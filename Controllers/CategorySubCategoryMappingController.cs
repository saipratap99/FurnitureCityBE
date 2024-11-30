using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureCityBE.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CategorySubCategoryMappingController(FurnitureStoreDb dbContext) : ControllerBase
{
    private readonly FurnitureStoreDb _dbContext = dbContext;
    private readonly GenericRepository<CategorySubCategoryMapping> _repository = new(dbContext);
    
    
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<CategorySubCategoryMapping>>> Index()
    {
        return Ok(await _repository.GetAll());
    }

    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<object>> Create(CategorySubCategoryMapping subCategory)
    {
        _repository.Add(subCategory);
        await _repository.Savechange();
        return Ok(subCategory);
    }

    [HttpGet]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<CategorySubCategoryMapping>> Get(Guid id)
    {
        return Ok(await _repository.GetById(id));
    }
    
    [HttpPut]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<CategorySubCategoryMapping>> Update(Guid id, CategorySubCategoryMapping subCategory)
    {
        var categoryItem = await _repository.GetById(id);
        if (categoryItem == null)
            return NotFound("Category not found");
        _repository.Edit(categoryItem);
        await _repository.Savechange();
        return Ok("Sub-Category updated");
    }
        
    [HttpDelete]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<CategorySubCategoryMapping>> Delete(Guid id)
    {
        var categoryItem = await _repository.GetById(id);
        if (categoryItem == null)
            return NotFound("Sub-Category not found");
        _repository.Del(id);
        await _repository.Savechange();
        return Ok("Sub-Category Deleted");
    }
}

