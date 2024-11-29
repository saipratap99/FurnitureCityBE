using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureCityBE.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class LeadHistoryController(FurnitureStoreDb dbContext) : ControllerBase
{
    private readonly FurnitureStoreDb _dbContext = dbContext;
    private readonly GenericRepository<LeadHistory> _repository = new(dbContext);

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<LeadHistory>>> Index()
    {
        return Ok(await _repository.GetAll());
    }

    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<LeadHistory>> Create(LeadHistory leadHistory)
    {
        _repository.Add(leadHistory);
        await _repository.Savechange();
        return Ok(leadHistory);
    }

    [HttpGet]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<LeadHistory>> Get(Guid id)
    {
        return Ok(await _repository.GetById(id));
    }
}
