using System.ComponentModel.DataAnnotations;

namespace FurnitureCityBE.Models;

public class User
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [MaxLength(15)]
    public string Mobile { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [MaxLength(50)]
    public string Role { get; set; }

    public ICollection<SavedAddress>? SavedAddresses { get; set; }
    public ICollection<Order>? Orders { get; set; }
}
