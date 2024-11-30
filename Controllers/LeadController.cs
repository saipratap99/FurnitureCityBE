using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureCityBE.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class LeadController(FurnitureStoreDb dbContext) : ControllerBase
{
    private readonly FurnitureStoreDb _dbContext = dbContext;
    private readonly GenericRepository<Lead> _repository = new(dbContext);

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Lead>>> Index()
    {
        return Ok(await _repository.GetAll());
    }

    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<LeadHistory>> Create(Lead lead)
    {
        _repository.Add(lead);
        await _repository.Savechange();
        return Ok(lead);
    }

    [HttpGet]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<Lead>> Get(Guid id)
    {
        return Ok(await _repository.GetById(id));
    }
}
