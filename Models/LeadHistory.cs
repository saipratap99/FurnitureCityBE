using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class LeadHistory
{
    [Key]
    public Guid Id { get; set; }

    [MaxLength(500)]
    public string Comments { get; set; }

    public DateTime Date { get; set; }

    [Required]
    public Guid LeadId { get; set; }
    [ForeignKey("LeadId")]
    public Lead Lead { get; set; }
}
