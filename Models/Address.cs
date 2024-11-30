using System.ComponentModel.DataAnnotations;

namespace FurnitureCityBE.Models;

public class Address
{
    [Key]
    public Guid Id { get; set; }

    [MaxLength(50)]
    public string AppartmentNo { get; set; }

    [MaxLength(100)]
    public string Road { get; set; }

    [Required]
    [MaxLength(50)]
    public string City { get; set; }

    [Required]
    [MaxLength(50)]
    public string State { get; set; }

    [Required]
    [MaxLength(10)]
    public string Zipcode { get; set; }
}
