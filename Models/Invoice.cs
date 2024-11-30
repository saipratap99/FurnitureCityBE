using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class Invoice
{
    [Key]
    public Guid invoice_id { get; set; }

    public DateTime date { get; set; }

    [Required]
    [MaxLength(50)]
    public string number { get; set; }

    //[Range(0.01, double.MaxValue)]
    //public decimal NetAmount { get; set; }

    [Range(0.00, double.MaxValue)]
    public decimal tax { get; set; }

    [Range(0.01, double.MaxValue)]
    public decimal totalAmount { get; set; }
    
    [Required]
    public Guid order_id { get; set; }
    [ForeignKey("order_id")]
    public Order Order { get; set; }
}
