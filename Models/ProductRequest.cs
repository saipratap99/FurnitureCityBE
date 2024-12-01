namespace FurnitureCityBE.Models;

public class ProductRequest
{
    public String Name { get; set; }
    public String Description { get; set; }
    public Double Price { get; set; }
    public int Quantity { get; set; }
    public Boolean IsActive { get; set; }
    public Guid SubCategoryId { get; set; }
    public List<Guid> ProductTags { get; set; }
    public List<String> ProductImages { get; set; } 
}

