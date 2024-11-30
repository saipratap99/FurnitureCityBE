using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FurnitureCityBE.Models;

public class CategorySubCategoryMapping
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }

    [Required]
    public Guid SubCategoryId { get; set; }
    
    [ForeignKey("SubCategoryId")]
    public SubCategory? SubCategory { get; set; }
}
