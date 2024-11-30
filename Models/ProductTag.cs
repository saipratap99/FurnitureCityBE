using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class ProductTag
{
    [Key]
    public Guid product_tag_id { get; set; }

    [Required]
    [MaxLength(100)]
    public string name { get; set; }
    
    public Guid retailer_id { get; set; }
    [ForeignKey("retailer_id")]
    public Retailer Retailer { get; set; }
}
