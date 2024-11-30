using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class Order
{
    [Key]
    public Guid order_id { get; set; }

    [Required]
    [MaxLength(50)]
    public string orderStatus { get; set; }

    [MaxLength(50)]
    public string deliveryMethod { get; set; }
    public DateTime orderDate { get; set; }
    
    public ICollection<OrderItem>? OrderItems { get; set; }
    //public ICollection<ShipmentStatus>? ShipmentStatusCollection { get; set; }
    public Invoice Invoice { get; set; }
}
