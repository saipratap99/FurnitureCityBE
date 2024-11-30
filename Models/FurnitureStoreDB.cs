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

      var sofasSubCategoryId = new SubCategory { Id = new Guid("f106601e-296d-4c77-a7f3-522015498e3c"), Name = "Sofas" };
      var bedsSubCategoryId = new SubCategory { Id = new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10"), Name = "Beds" };
      var desksSubCategoryId = new SubCategory { Id = new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31"), Name = "Desks" };
      // Seed SubCategories
      modelBuilder.Entity<SubCategory>().HasData(
       sofasSubCategoryId,
       bedsSubCategoryId,
       desksSubCategoryId
      );

      var testUser = new User { Id = new Guid("cf7cc03c-172f-4b11-882d-e463796a1a40"), Email = "test@test.com", Password = "test",  Role = UserRoles.USER.ToString(), Mobile = "234565432", Name = "test"};
      modelBuilder.Entity<User>().HasData(testUser);
      //
      // modelBuilder.Entity<CategorySubCategoryMapping>().HasData(
      //     new CategorySubCategoryMapping
      //     {
      //         Id = Guid.NewGuid(), SubCategoryId = sofasSubCategoryId.Id, CategoryId = livingRoomCategoryId.Id
      //     },
      //   new CategorySubCategoryMapping{Id = Guid.NewGuid(), SubCategoryId = sofasSubCategoryId.Id, CategoryId = bedsSubCategoryId.Id},
      //   new CategorySubCategoryMapping{Id = Guid.NewGuid(), SubCategoryId = sofasSubCategoryId.Id, CategoryId = officeCategoryId.Id},
      //   new CategorySubCategoryMapping{Id = Guid.NewGuid(), SubCategoryId = desksSubCategoryId.Id, CategoryId = bedsSubCategoryId.Id},
      // new CategorySubCategoryMapping{Id = Guid.NewGuid(), SubCategoryId = desksSubCategoryId.Id, CategoryId = officeCategoryId.Id},
      // new CategorySubCategoryMapping{Id = Guid.NewGuid(), SubCategoryId = bedsSubCategoryId.Id, CategoryId = bedroomCategoryId.Id}
      // );



      // // Seed Products
      // modelBuilder.Entity<Product>().HasData(
      //   new Product
      //   {
      //     Id = Guid.NewGuid(),
      //     Name = "Modern Sofa",
      //     Description = "A stylish modern sofa for your living room.",
      //     IsActive = true,
      //     Quantity = 10,
      //     Price = 599.99M,
      //     SubCategoryId = sofasSubCategoryId.Id
      //   },
      //   new Product
      //   {
      //     Id = Guid.NewGuid(),
      //     Name = "King Size Bed",
      //     Description = "A spacious and comfortable king-size bed.",
      //     IsActive = true,
      //     Quantity = 5,
      //     Price = 799.99M,
      //     SubCategoryId = bedsSubCategoryId.Id
      //   },
      //   new Product
      //   {
      //     Id = Guid.NewGuid(),
      //     Name = "Ergonomic Office Desk",
      //     Description = "A height-adjustable ergonomic desk for your office.",
      //     IsActive = true,
      //     Quantity = 8,
      //     Price = 299.99M,
      //     SubCategoryId = desksSubCategoryId.Id
      //   },
      //   // Living Room - Sofas
      //   new Product
      //   {
      //       Id = Guid.NewGuid(),
      //       Name = "Modern Leather Sofa",
      //       Description = "A sleek leather sofa that adds sophistication to any living room.",
      //       IsActive = true,
      //       Quantity = 15,
      //       Price = 799.99M,
      //       SubCategoryId = sofasSubCategoryId.Id
      //   },
      //   new Product
      //   {
      //       Id = Guid.NewGuid(),
      //       Name = "Sectional Fabric Sofa",
      //       Description = "A spacious and comfortable sectional sofa perfect for family gatherings.",
      //       IsActive = true,
      //       Quantity = 10,
      //       Price = 899.99M,
      //       SubCategoryId = sofasSubCategoryId.Id
      //   },
      //   new Product
      //   {
      //       Id = Guid.NewGuid(),
      //       Name = "Convertible Sofa Bed",
      //       Description = "A multi-functional sofa bed with a contemporary design.",
      //       IsActive = true,
      //       Quantity = 8,
      //       Price = 499.99M,
      //       SubCategoryId = sofasSubCategoryId.Id
      //   },
      //
      //   // Bedroom - Beds
      //   new Product
      //   {
      //       Id = Guid.NewGuid(),
      //       Name = "Queen Size Wooden Bed",
      //       Description = "A solid wooden bed frame with a classic finish.",
      //       IsActive = true,
      //       Quantity = 20,
      //       Price = 699.99M,
      //       SubCategoryId = bedsSubCategoryId.Id
      //   },
      //   new Product
      //   {
      //       Id = Guid.NewGuid(),
      //       Name = "King Size Upholstered Bed",
      //       Description = "A luxurious bed with a tufted headboard and sturdy build.",
      //       IsActive = true,
      //       Quantity = 10,
      //       Price = 999.99M,
      //       SubCategoryId = bedsSubCategoryId.Id
      //   },
      //   new Product
      //   {
      //       Id = Guid.NewGuid(),
      //       Name = "Bunk Bed with Storage",
      //       Description = "Perfect for kids, this bunk bed includes under-bed storage drawers.",
      //       IsActive = true,
      //       Quantity = 5,
      //       Price = 799.99M,
      //       SubCategoryId = bedsSubCategoryId.Id
      //   },
      //
      //   // Office - Desks
      //   new Product
      //   {
      //       Id = Guid.NewGuid(),
      //       Name = "Adjustable Standing Desk",
      //       Description = "A height-adjustable desk designed for ergonomic office setups.",
      //       IsActive = true,
      //       Quantity = 12,
      //       Price = 399.99M,
      //       SubCategoryId = desksSubCategoryId.Id
      //   },
      //   new Product
      //   {
      //       Id = Guid.NewGuid(),
      //       Name = "Executive Wooden Desk",
      //       Description = "A spacious executive desk with a rich mahogany finish.",
      //       IsActive = true,
      //       Quantity = 7,
      //       Price = 899.99M,
      //       SubCategoryId = desksSubCategoryId.Id
      //   },
      //   new Product
      //   {
      //       Id = Guid.NewGuid(),
      //       Name = "Compact Computer Desk",
      //       Description = "A minimalist computer desk with a sleek design.",
      //       IsActive = true,
      //       Quantity = 20,
      //       Price = 199.99M,
      //       SubCategoryId = desksSubCategoryId.Id
      //   }
      // );

      // Seed Product Tags
      modelBuilder.Entity<ProductTag>().HasData(
        new ProductTag { product_tag_id = Guid.NewGuid(), name = "Modern" },
        new ProductTag { product_tag_id = Guid.NewGuid(), name = "Luxury" },
        new ProductTag { product_tag_id = Guid.NewGuid(), name = "Ergonomic" }
      );


            // Configure relationships and constraints

            // Example: Composite key in case it's needed (optional)
            // modelBuilder.Entity<CategorySubCategoryMapping>()
            //     .HasKey(csc => new { csc.CategoryId, csc.SubCategoryId });

            // Seed data (if any) can be added here
        }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var livingRoomCategoryId = new Category
            { Id = new Guid("e06629eb-de6b-41e1-b4e9-01d6bac0a3c0"), Name = "Living Room" };
        var bedroomCategoryId = new Category
            { Id = new Guid("94d4fdb7-b1b7-4b42-aea4-08dc058baf26"), Name = "Bedroom" };
        var officeCategoryId = new Category { Id = new Guid("44a1f781-0906-45a0-888f-041790c7603f"), Name = "Office" };
        // Seed Categories
        modelBuilder.Entity<Category>().HasData(
            livingRoomCategoryId,
            bedroomCategoryId,
            officeCategoryId
        );

        var sofasSubCategoryId = new SubCategory
            { Id = new Guid("f106601e-296d-4c77-a7f3-522015498e3c"), Name = "Sofas" };
        var bedsSubCategoryId = new SubCategory
            { Id = new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10"), Name = "Beds" };
        var desksSubCategoryId = new SubCategory
            { Id = new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31"), Name = "Desks" };
        // Seed SubCategories
        modelBuilder.Entity<SubCategory>().HasData(
            sofasSubCategoryId,
            bedroomCategoryId,
            desksSubCategoryId
        );

        modelBuilder.Entity<CategorySubCategoryMapping>().HasData(
            new CategorySubCategoryMapping
            {
                Id = Guid.NewGuid(), SubCategoryId = sofasSubCategoryId.Id, CategoryId = livingRoomCategoryId.Id
            },
            new CategorySubCategoryMapping
                { Id = Guid.NewGuid(), SubCategoryId = sofasSubCategoryId.Id, CategoryId = bedsSubCategoryId.Id },
            new CategorySubCategoryMapping
                { Id = Guid.NewGuid(), SubCategoryId = sofasSubCategoryId.Id, CategoryId = officeCategoryId.Id },
            new CategorySubCategoryMapping
                { Id = Guid.NewGuid(), SubCategoryId = desksSubCategoryId.Id, CategoryId = bedsSubCategoryId.Id },
            new CategorySubCategoryMapping
                { Id = Guid.NewGuid(), SubCategoryId = desksSubCategoryId.Id, CategoryId = officeCategoryId.Id },
            new CategorySubCategoryMapping
                { Id = Guid.NewGuid(), SubCategoryId = bedsSubCategoryId.Id, CategoryId = bedroomCategoryId.Id }
        );



        // Seed Products

    }

}
