using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models
{
  public class Product
  {
    [Key]
    public Guid product_id { get; set; }

    [Required]
    [MaxLength(200)]
    public string name { get; set; }

    [MaxLength(500)]
    public string description { get; set; }

    public bool isActive { get; set; }

    [Range(0, int.MaxValue)]
    public int quantity { get; set; }

    [Range(0.01, double.MaxValue)]
    public decimal price { get; set; }

    [Required]
    public Guid subcategory_id { get; set; }
    [ForeignKey("subcategory_id")]
    public SubCategory SubCategory { get; set; }
    
    public Guid retailer_id { get; set; }
    [ForeignKey("retailer_id")]
    public Retailer Retailer { get; set; }

    public ICollection<ProductImage>? ProductImages { get; set; }
    public ICollection<ProductTagsMapping>? ProductTagsMappings { get; set; }
    public ICollection<ProductReview>? ProductReviews { get; set; }
  }
}
