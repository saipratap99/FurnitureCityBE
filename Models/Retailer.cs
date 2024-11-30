using System.ComponentModel.DataAnnotations;

namespace FurnitureCityBE.Models;

public class Retailer
{
    [Key]
    public Guid retailer_id { get; set; }
    
    [MaxLength(100)]
    public string name { get; set; }
    
    [MaxLength(100)]
    public string contact_information { get; set; }
}