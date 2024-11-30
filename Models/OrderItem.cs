using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class OrderItem
{
    [Key]
    public Guid order_item_id { get; set; }

    [Required]
    public Guid order_id { get; set; }
    [ForeignKey("order_id")]
    public Order Order { get; set; }
    
    public Guid product_id { get; set; }
    [ForeignKey("product_id")]
    public Product Product { get; set; }

    [Range(1, int.MaxValue)]
    public int quantity { get; set; }
}
