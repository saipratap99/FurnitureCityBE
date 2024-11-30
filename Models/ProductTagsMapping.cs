using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class ProductTagsMapping
{
    [Key]
    public Guid prod_prodTag_id { get; set; }

    [Required]
    public Guid product_id { get; set; }
    [ForeignKey("product_id")]
    public Product Product { get; set; }

    [Required]
    public Guid product_tag_id { get; set; }
    [ForeignKey("product_tag_id")]
    public ProductTag ProductTag { get; set; }
}
