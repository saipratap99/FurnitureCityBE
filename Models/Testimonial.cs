using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class Testimonial
{
    [Key]
    public Guid testimonial_id { get; set; }

    [Required]
    [MaxLength(100)]
    public string name { get; set; }

    [MaxLength(50)]
    public string role { get; set; }

    [MaxLength(100)]
    public string company { get; set; }

    public string testimonialText { get; set; }

    public DateTime date { get; set; }
   
    
    public Guid user_id { get; set; }
    [ForeignKey(name:"user_id")]
    public User user { get; set; }
  
}
