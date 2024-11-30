using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class LeadHistory
{
    [Key]
    public Guid lead_history_id { get; set; }

    [MaxLength(500)]
    public string comment { get; set; }

    public DateTime date { get; set; }

    [Required]
    public Guid leads_id { get; set; }
    [ForeignKey("leads_id")]
    public Lead Lead { get; set; }
}
