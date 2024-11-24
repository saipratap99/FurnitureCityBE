using Microsoft.EntityFrameworkCore;

namespace FurnitureCityBE.Models
{
  public class FurnitureStoreDb : DbContext
  {
    public FurnitureStoreDb(DbContextOptions<FurnitureStoreDb> options) : base(options)
    {

    }

    // DbSets for each entity
    public DbSet<Category> Categories { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<CategorySubCategoryMapping> CategorySubCategoryMappings { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<ProductTagsMapping> ProductTagsMappings { get; set; }
    public DbSet<ProductTag> ProductTags { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<SavedAddress> SavedAddresses { get; set; }
    public DbSet<ContactUs> ContactUs { get; set; }
    public DbSet<ProductReview> ProductReviews { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<StoreLocation> StoreLocations { get; set; }
    public DbSet<ShipmentStatus> ShipmentStatuses { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Lead> Leads { get; set; }
    public DbSet<LeadHistory> LeadHistories { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
      // base.OnModelCreating(modelBuilder);

      // Configure relationships and constraints

      // Example: Composite key in case it's needed (optional)
      // modelBuilder.Entity<CategorySubCategoryMapping>()
      //     .HasKey(csc => new { csc.CategoryId, csc.SubCategoryId });

      // Seed data (if any) can be added here
    // }

  }

}
