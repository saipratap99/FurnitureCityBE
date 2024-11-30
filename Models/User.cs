using System.ComponentModel.DataAnnotations;

namespace FurnitureCityBE.Models;

public class User
{
    [Key]
    public Guid user_id { get; set; }

    [Required]
    [MaxLength(100)]
    public string name { get; set; }

    [Required]
    [MaxLength(15)]
    public string mobile { get; set; }

    [Required]
    [EmailAddress]
    public string email { get; set; }

    [Required]
    public string password { get; set; }

    [MaxLength(50)]
    public string role { get; set; }

    public ICollection<SavedAddress>? SavedAddresses { get; set; }
    public ICollection<Order>? Orders { get; set; }
}
