using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class StoreLocation
{
    [Key]
    public Guid store_location_id { get; set; }

    [Required]
    public Guid address_id { get; set; }
    [ForeignKey("address_id")]
    public Address Address { get; set; }

    public DateTime storeStartDate { get; set; }
}
