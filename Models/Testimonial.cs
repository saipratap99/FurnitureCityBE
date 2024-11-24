using System.ComponentModel.DataAnnotations;

namespace FurnitureCityBE.Models;

public class Testimonial
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(50)]
    public string Role { get; set; }

    [MaxLength(100)]
    public string Company { get; set; }

    public string TestimonialText { get; set; }

    public DateTime Date { get; set; }
}
