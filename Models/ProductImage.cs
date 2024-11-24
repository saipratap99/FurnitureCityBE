using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class ProductImage
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string ImageUrl { get; set; }

    [MaxLength(200)]
    public string AltText { get; set; }

    [Required]
    public Guid ProductId { get; set; }
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
}
