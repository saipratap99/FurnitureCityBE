using FurnitureCityBE.Exceptions;
using FurnitureCityBE.Models;
using Microsoft.EntityFrameworkCore;

namespace FurnitureCityBE.Repositories;

public class CategoryRepository: ICategoryRepository
{
    private readonly FurnitureStoreDb _context;

    public CategoryRepository(FurnitureStoreDb context)
    {
        _context = context;
    }
    
    public async Task<Category> CreateCategoryAsync(Category category)
    {
        _context.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<List<Category>> GetAllCategoriesAsync()
    {
        return await _context.Categories.ToListAsync<Category>();
    }

    public async Task<Category> GetCategoryByIdAsync(Guid categoryId)
    {
        var category = await _context.Categories.FirstOrDefaultAsync(category => category.Id == categoryId);

        if (category == null)
            throw new NotFoundException($"Category with id {categoryId} not found");

        return category;
    }
}
