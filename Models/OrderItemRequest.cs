using System.ComponentModel.DataAnnotations;

public class OrderItemRequest
{

    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }
    
    [Required]
    public Guid ProductId { get; set; }
    
    [Required]
    public Guid userId { get; set; }
    
}
