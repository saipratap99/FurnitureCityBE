using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;


public class ProductReview
{
    [Key]
    public Guid review_id { get; set; }

    [MaxLength(500)]
    public string comments { get; set; }

    [Range(1, 5)]
    public int rating { get; set; }

    [Required]
    public Guid product_id { get; set; }
    [ForeignKey("product_id")]
    public Product Product { get; set; }

    [Required]
    public Guid user_id { get; set; }
    [ForeignKey("user_id")]
    public User User { get; set; }
}
