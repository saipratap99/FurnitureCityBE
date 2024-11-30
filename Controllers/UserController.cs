using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureCityBE.Controllers;
[Route("api/v1/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly FurnitureStoreDb _dbContext;
    private readonly GenericRepository<User> _repository;

    public UserController(FurnitureStoreDb dbContext)
    {
        _dbContext = dbContext;
        _repository = new GenericRepository<User>(dbContext);
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<User>>> Index()
    {
        return Ok(await _repository.GetAll());
    }

    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<object>> Create(User user)
    {
        _repository.Add(user);
        await _repository.Savechange();
        return Ok(user);
    }

    [HttpGet]
    [Route("[Action]/{id}")]
    public async Task<ActionResult<User>> Get(Guid id)
    {
        return Ok(await _repository.GetById(id));
    }
/*
    // Register API
    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<object>> Register(User user)
    {
        // Check if email already exists
        var existingUser = await _repository.Find(u => u.Email == user.Email);
        if (existingUser != null)
        {
            return BadRequest(new { message = "Email is already registered." });
        }

        user.Id = Guid.NewGuid();

        _repository.Add(user);
        await _repository.Savechange();

        return Ok(new { message = "Registration successful.", userId = user.Id });
    }
    */
/*
    // Login API
    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<object>> Login(string email, string password)
    {
        var user = await _repository.Find(u => u.Email == email);
        if (user == null || user.Password != password)
        {
            return Unauthorized(new { message = "Invalid email or password." });
        }

        // Determine the login success message based on the user's role
        string loginMessage = user.Role.ToLower() switch
        {
            "admin" => "Admin login successful.",
            "user" => "User login successful.",
            _ => "Login successful."
        };

        return Ok(new { message = loginMessage, userId = user.Id, userRole = user.Role });
    }
    */

}
