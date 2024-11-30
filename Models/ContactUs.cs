using System.ComponentModel.DataAnnotations;

namespace FurnitureCityBE.Models;
public class ContactUs
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MaxLength(200)]
    public string Subject { get; set; }

    public string Description { get; set; }
}
