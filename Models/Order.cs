using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class Order
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Status { get; set; }

    [Required]
    [MaxLength(50)]
    public string OrderId { get; set; }

    [Required]
    public Guid UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }

    public ICollection<OrderItem>? OrderItems { get; set; }
    public ICollection<ShipmentStatus>? ShipmentStatuses { get; set; }
    public Invoice Invoice { get; set; }
}
