using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureCityBE.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ContactUsController(FurnitureStoreDb dbContext) : ControllerBase
{
    private readonly FurnitureStoreDb _dbContext = dbContext;
    private readonly GenericRepository<ContactUs> _repository = new(dbContext);

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<ContactUs>>> Index()
    {
        return Ok(await _repository.GetAll());
    }

    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<ContactUs>> Create(ContactUs contactUs)
    {
        _repository.Add(contactUs);
        await _repository.Savechange();
        return Ok(contactUs);
    }

    [HttpGet]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<ContactUs>> Get(Guid id)
    {
        return Ok(await _repository.GetById(id));
    }
}
