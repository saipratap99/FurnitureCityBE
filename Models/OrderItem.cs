using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class OrderItem
{
    [Key]
    public Guid order_item_id { get; set; }

    [Required]
    public Guid OrderId { get; set; }
    
    [ForeignKey("OrderId")]
    public Order Order { get; set; }
    
    public Guid product_id { get; set; }
    [ForeignKey("product_id")]
    public Product Product { get; set; }

    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }
    
    [Required]
    public Guid ProductId { get; set; }
    
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
}
