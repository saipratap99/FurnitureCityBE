using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        policy => policy.WithOrigins("http://localhost:3000") // Replace with your frontend URL
            .AllowAnyHeader()
            .AllowAnyMethod());
});
builder.Services.AddDbContext<FurnitureStoreDb>(options =>
{
    // options.UseMySql(builder.Configuration["db:MySqlDevEnv"], new MySqlServerVersion(new Version(8, 0, 21)));
    options.UseMySQL(builder.Configuration["db:MySqlDevEnv"]);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("AllowSpecificOrigin");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
