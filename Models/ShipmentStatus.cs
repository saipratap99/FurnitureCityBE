using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class ShipmentStatus
{
    [Key]
    public Guid shipment_id { get; set; }

    [Required]
    [MaxLength(50)]
    public string status { get; set; }
    
    [Required]
    public Guid address_id { get; set; }
    [ForeignKey("address_id")]
    public Order Address { get; set; }

    [Required]
    public Guid order_id { get; set; }
    [ForeignKey("order_id")]
    public Order Order { get; set; }
}
