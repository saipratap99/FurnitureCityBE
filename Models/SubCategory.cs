namespace FurnitureCityBE.Models;
using System.ComponentModel.DataAnnotations;

public class SubCategory
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public ICollection<CategorySubCategoryMapping>? CategorySubCategoryMappings { get; set; }
    public ICollection<Product>? Products { get; set; }
}
