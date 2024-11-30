namespace FurnitureCityBE.Models;
using System.ComponentModel.DataAnnotations;


public class Category
{
    [Key]
    public Guid category_id { get; set; }

    [Required]
    [MaxLength(100)]
    public string name { get; set; }

    public ICollection<CategorySubCategoryMapping>? CategorySubCategoryMappings { get; set; }
}
