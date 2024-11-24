using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class StoreLocation
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid AddressId { get; set; }
    [ForeignKey("AddressId")]
    public Address Address { get; set; }

    public DateTime StoreStartDate { get; set; }
}
