using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureCityBE.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly FurnitureStoreDb _dbContext;
        private readonly GenericRepository<Testimonial> _repository;

        public TestimonialController(FurnitureStoreDb dbContext)
        {
            _dbContext = dbContext;
            _repository = new GenericRepository<Testimonial>(dbContext);
        }

        // Get all testimonials
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Testimonial>>> GetAllTestimonials()
        {
            try
            {
                var testimonials = await _repository.GetAll();
                return Ok(testimonials);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error fetching testimonials.", error = ex.Message });
            }
        }

        // Get a single testimonial by ID
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Testimonial>> GetTestimonialById(Guid id)
        {
            try
            {
                var testimonial = await _repository.GetById(id);
                if (testimonial == null)
                {
                    return NotFound(new { message = "Testimonial not found." });
                }
                return Ok(testimonial);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error fetching testimonial.", error = ex.Message });
            }
        }
    }
}