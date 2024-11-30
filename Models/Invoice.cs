using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureCityBE.Models;

public class Invoice
{
    [Key]
    public Guid Id { get; set; }

    public DateTime Date { get; set; }

    [Required]
    [MaxLength(50)]
    public string InvoiceNumber { get; set; }

    [Range(0.01, double.MaxValue)]
    public decimal NetAmount { get; set; }

    [Range(0.00, double.MaxValue)]
    public decimal TaxAmount { get; set; }

    [Range(0.01, double.MaxValue)]
    public decimal TotalAmount { get; set; }

    [Required]
    public Guid OrderId { get; set; }
    [ForeignKey("OrderId")]
    public Order Order { get; set; }
}
