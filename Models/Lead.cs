using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class Lead
{
    [Key]
    public Guid Id { get; set; }

    public DateTime LeadStartDate { get; set; }

    [MaxLength(50)]
    public string LeadStatus { get; set; }

    public DateTime NextEnquiryDate { get; set; }

    [Required]
    public Guid ContactUsId { get; set; }
    [ForeignKey("ContactUsId")]
    public ContactUs ContactUs { get; set; }

    public ICollection<LeadHistory>? LeadHistories { get; set; }
}
