using System.ComponentModel.DataAnnotations;

namespace FurnitureCityBE.Models;

public class Address
{
    [Key]
    public Guid address_id { get; set; }

    [MaxLength(50)]
    public string aptNo { get; set; }

    [MaxLength(100)]
    public string road { get; set; }

    [Required]
    [MaxLength(50)]
    public string city { get; set; }

    [Required]
    [MaxLength(50)]
    public string state { get; set; }

    [Required]
    [MaxLength(10)]
    public string zipcode { get; set; }
    
}
