using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureCityBE.Controllers;
[Route("api/v1/[controller]")]
[ApiController]
public class InvoiceController:ControllerBase
{
    private readonly FurnitureStoreDb _dbContext;
    private readonly GenericRepository<Invoice> _repository;

    public InvoiceController(FurnitureStoreDb dbContext)
    {
        _dbContext = dbContext;
        _repository = new GenericRepository<Invoice>(dbContext);
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Invoice>>> Index()
    {
        return Ok(await _repository.GetAll());
    }
    
    
    [HttpGet]
    [Route("[Action]/{orderId}")]
    public async Task<ActionResult<Invoice>> Get(Guid orderId)
    {
        var invoice = await _repository.GetInvoiceByOrderId(orderId);
        if (invoice == null)
            return NotFound("invoice not found");
        return Ok(invoice);
    }
    
}