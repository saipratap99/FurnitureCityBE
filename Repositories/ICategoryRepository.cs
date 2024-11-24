using FurnitureCityBE.Models;

namespace FurnitureCityBE.Repositories;

public interface ICategoryRepository
{
    public Task<Category> CreateCategoryAsync(Category category);

    public Task<List<Category>> GetAllCategoriesAsync();
    public Task<Category> GetCategoryByIdAsync(Guid categoryId);
}
