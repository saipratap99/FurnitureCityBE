using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FurnitureCityBE.Models;

public class CategorySubCategoryMapping
{
    [Key]
    public Guid sub_cat_id { get; set; }

    [Required]
    public Guid category_id { get; set; }
    [ForeignKey("category_id")]
    public Category Category { get; set; }

    [Required]
    public Guid subcategory_id { get; set; }
    [ForeignKey("subcategory_id")]
    public SubCategory SubCategory { get; set; }
}
