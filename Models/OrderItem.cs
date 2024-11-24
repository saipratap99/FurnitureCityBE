using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class OrderItem
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid OrderId { get; set; }
    [ForeignKey("OrderId")]
    public Order Order { get; set; }

    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }
}
