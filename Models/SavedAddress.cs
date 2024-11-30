using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class SavedAddress
{
    [Key]
    public Guid saved_address_id { get; set; }

    [Required]
    public Guid user_id { get; set; }
    [ForeignKey("user_id")]
    public User User { get; set; }

    [Required]
    public Guid address_id { get; set; }
    [ForeignKey("address_id")]
    public Address Address { get; set; }
}
