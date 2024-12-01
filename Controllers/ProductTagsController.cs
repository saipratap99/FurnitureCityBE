using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureCityBE.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ProductTagsController(FurnitureStoreDb dbContext) : ControllerBase
{
    private readonly FurnitureStoreDb _dbContext = dbContext;
    private readonly GenericRepository<ProductTag> _repository = new(dbContext);
    
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<ProductTag>>> Index()
    {
        return Ok(await _repository.GetAll());
    }

    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<ProductTag>> Create(ProductTag tag)
    {
        _repository.Add(tag);
        await _repository.Savechange();
        return Ok(tag);
    }

    [HttpGet]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<ProductTag>> Get(Guid id)
    {
        return Ok(await _repository.GetById(id));
    }
    
    [HttpPut]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<ProductTag>> Update(Guid id, ProductTag productTag)
    {
        var productTagFound = await _repository.GetById(id);
        if (productTagFound == null)
            return NotFound("Product Tag not found");
        productTagFound.Name = productTag.Name;
        _repository.Edit(productTagFound);
        await _repository.Savechange();
        return Ok("Product Tag updated");
    }
        
    [HttpDelete]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<ProductTag>> Delete(Guid id)
    {
        var productTag = await _repository.GetById(id);
        if (productTag == null)
            return NotFound("Product tag not found");
        _repository.Del(id);
        await _repository.Savechange();
        return Ok("Product tag Deleted");
    }
}

