using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class Lead
{
    [Key]
    public Guid leads_id { get; set; }

    //public DateTime LeadStartDate { get; set; }

    [MaxLength(50)]
    public string leadStatus { get; set; }

    public DateTime nextEnquiryDate { get; set; }

    [Required]
    public Guid contact_id { get; set; }
    [ForeignKey("contact_id")]
    public ContactUs ContactUs { get; set; }

    public ICollection<LeadHistory>? LeadHistories { get; set; }
}
