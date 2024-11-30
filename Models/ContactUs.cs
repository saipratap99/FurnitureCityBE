using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;
public class ContactUs
{
    [Key]
    public Guid contact_id { get; set; }

    [Required]
    [MaxLength(100)]
    public string name { get; set; }

    [Required]
    [EmailAddress]
    public string email { get; set; }

    [Required]
    [MaxLength(200)]
    public string subject { get; set; }

    public string description { get; set; }
    
    public Guid user_id { get; set; }
    [ForeignKey("user_id")]
    public Order User { get; set; }
}
