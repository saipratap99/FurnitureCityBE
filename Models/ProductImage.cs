using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class ProductImage
{
    [Key]
    public Guid p_image_id { get; set; }

    [Required]
    public string imageUrl { get; set; }

    [MaxLength(200)]
    public string altText { get; set; }

    [Required]
    public Guid product_id { get; set; }
    [ForeignKey("product_id")]
    public Product Product { get; set; }
}
