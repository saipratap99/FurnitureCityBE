namespace FurnitureCityBE.Models;
using System.ComponentModel.DataAnnotations;

public class SubCategory
{
    [Key][Required] public Guid subcategory_id { get; set; } 

    [Required]
    [MaxLength(100)]
    public string name { get; set; }

    //public ICollection<CategorySubCategoryMapping>? CategorySubCategoryMappings { get; set; }
<<<<<<< Updated upstream
    //public ICollection<Product>? Products { get; set; }
=======
    public ICollection<Product>? Products { get; set; }
>>>>>>> Stashed changes
}
