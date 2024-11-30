using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurnitureCityBE.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CategorySubCategoryMappingController(FurnitureStoreDb dbContext) : ControllerBase
{
    private readonly FurnitureStoreDb _dbContext = dbContext;
    private readonly GenericRepository<CategorySubCategoryMapping> _repository = new(dbContext);
    
    [HttpPost]
    [Route("[Action]/{subCategoryId}")]
    public async Task<ActionResult<object>> AssignCategoriesToSubCategory(Guid subCategoryId,List<CategorySubCategoryMapping> mappings)
    {
        // Fetch existing mappings for the subcategory
        var existingMappings = await _dbContext.CategorySubCategoryMappings
            .Where(mapping => mapping.SubCategoryId == subCategoryId)
            .ToListAsync();

        // Extract the IDs from the updated mappings
        var updatedCategoryIds = mappings.Select(mapping => mapping.CategoryId).ToList();

        // Identify mappings to be added
        var mappingsToAdd = mappings
            .Where(updatedMapping => !existingMappings.Any(existingMapping => existingMapping.CategoryId == updatedMapping.CategoryId))
            .ToList();

        // Identify mappings to be deleted
        var mappingsToDelete = existingMappings
            .Where(existingMapping => !updatedCategoryIds.Contains(existingMapping.CategoryId))
            .ToList();

        // Perform the additions
        if (mappingsToAdd.Any())
        {
            foreach (var mapping in mappingsToAdd)
            {
                mapping.Id = Guid.NewGuid(); // Ensure the ID is unique
                mapping.SubCategoryId = subCategoryId; // Set the subcategory ID
            }
            _dbContext.CategorySubCategoryMappings.AddRange(mappingsToAdd);
        }

        // Perform the deletions
        if (mappingsToDelete.Any())
        {
            _dbContext.CategorySubCategoryMappings.RemoveRange(mappingsToDelete);
        }

        // Save changes to the database
        await _dbContext.SaveChangesAsync();

        return Ok("Mappings updated");
    }

    
}

