namespace FurnitureCityBE.Models;

public class SubCategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<CategoryDto> Categories { get; set; }
}

public class CategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<SubCategoryDto>? SubCategories { get; set; }
}

public class ProductDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public SubCategoryDto SubCategory { get; set; }
    public List<ProductImageDto> Images { get; set; }
    public List<ProductTagDto> Tags { get; set; }
    public List<ProductReviewDto> Reviews { get; set; }
}

public class ProductImageDto
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }
    public string AltText { get; set; }
}

public class ProductTagDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}

public class ProductReviewDto
{
    public Guid Id { get; set; }
    public string Comments { get; set; }
    public int Rating { get; set; }
}

public class ContactUsDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
}

public class LeadHistoryDTO
{
    public Guid Id { get; set; }
    public string Comments { get; set; }
    public DateTime Date { get; set; }
}

public class LeadDTO
{
    public Guid Id { get; set; }
    public DateTime LeadStartDate { get; set; }
    public string LeadStatus { get; set; }
    public DateTime NextEnquiryDate { get; set; }
    public ContactUsDTO ContactUs { get; set; }
    public List<LeadHistoryDTO>? LeadHistories { get; set; }
}

