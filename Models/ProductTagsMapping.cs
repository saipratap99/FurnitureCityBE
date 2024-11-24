using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class ProductTagsMapping
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid ProductId { get; set; }
    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    [Required]
    public Guid ProductTagId { get; set; }
    [ForeignKey("ProductTagId")]
    public ProductTag ProductTag { get; set; }
}
