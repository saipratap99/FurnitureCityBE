using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;


public class ProductReview
{
    [Key]
    public Guid Id { get; set; }

    [MaxLength(500)]
    public string Comments { get; set; }

    [Range(1, 5)]
    public int Rating { get; set; }

    [Required]
    public Guid ProductId { get; set; }
    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    [Required]
    public Guid UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
}
