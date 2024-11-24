using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class ShipmentStatus
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Status { get; set; }

    [Required]
    public Guid OrderId { get; set; }
    [ForeignKey("OrderId")]
    public Order Order { get; set; }
}
