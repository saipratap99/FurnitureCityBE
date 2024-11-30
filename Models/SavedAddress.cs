using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class SavedAddress
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }

    [Required]
    public Guid AddressId { get; set; }
    [ForeignKey("AddressId")]
    public Address Address { get; set; }
}
