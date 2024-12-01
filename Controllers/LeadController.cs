using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        var leads = await _dbContext.Leads
            .Include(l => l.ContactUs)
            .Include(l => l.LeadHistories)
            .ToListAsync();
        var leadDTOs = leads.Select(lead => new LeadDTO
        {
            Id = lead.Id,
            LeadStartDate = lead.LeadStartDate,
            LeadStatus = lead.LeadStatus,
            NextEnquiryDate = lead.NextEnquiryDate,
            ContactUs = new ContactUsDTO
            {
                Id = lead.ContactUs.Id,
                Name = lead.ContactUs.Name,
                Email = lead.ContactUs.Email,
                Subject = lead.ContactUs.Subject,
                Description = lead.ContactUs.Description,
            },
            LeadHistories = lead.LeadHistories?.Select(history => new LeadHistoryDTO
            {
                Id = history.Id,
                Comments = history.Comments,
                Date = history.Date
            }).ToList()
        }).ToList();
        return Ok(leadDTOs);
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
    
    [HttpPost("{leadId}/history")]
    public async Task<ActionResult<Lead>> AddLeadHistory(Guid leadId, LeadHistoryRequest newHistory)
    {
        var lead = await _dbContext.Leads.Include(l => l.LeadHistories).Include(l => l.ContactUs).FirstOrDefaultAsync(l => l.Id == leadId);

        if (lead == null)
            return NotFound();

        var leadHistory = new LeadHistory { LeadId = leadId, Date = DateTime.Today, Comments = newHistory.comments };
        
        lead.LeadStatus = newHistory.status;
        lead.NextEnquiryDate = DateTime.Today.AddDays(10);
        _repository.Edit(lead);
        _dbContext.LeadHistories.Add(leadHistory);
        _dbContext.SaveChanges();

        var leadDTOs = new LeadDTO
        {
            Id = lead.Id,
            LeadStartDate = lead.LeadStartDate,
            LeadStatus = lead.LeadStatus,
            NextEnquiryDate = lead.NextEnquiryDate,
            ContactUs = new ContactUsDTO
            {
                Id = lead.ContactUs.Id,
                Name = lead.ContactUs.Name,
                Email = lead.ContactUs.Email,
                Subject = lead.ContactUs.Subject,
                Description = lead.ContactUs.Description,
            },
            LeadHistories = lead.LeadHistories?.Select(history => new LeadHistoryDTO
            {
                Id = history.Id,
                Comments = history.Comments,
                Date = history.Date
            }).ToList()
        };
        return Ok(leadDTOs);
    }
}
