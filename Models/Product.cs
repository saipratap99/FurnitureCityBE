using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models
{
  public class Product
  {
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; }

    [MaxLength(500)]
    public string Description { get; set; }

    public bool IsActive { get; set; }

    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }

    [Range(0.01, double.MaxValue)]
    public decimal Price { get; set; }

    [Required]
    public Guid SubCategoryId { get; set; }
    [ForeignKey("SubCategoryId")]
    public SubCategory SubCategory { get; set; }

    public ICollection<ProductImage>? ProductImages { get; set; }
    public ICollection<ProductTagsMapping>? ProductTagsMappings { get; set; }
    public ICollection<ProductReview>? ProductReviews { get; set; }
  }
}
