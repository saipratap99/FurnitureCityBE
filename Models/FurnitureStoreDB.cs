using Microsoft.EntityFrameworkCore;

namespace FurnitureCityBE.Models
{
  public class FurnitureStoreDb : DbContext
  {
    public FurnitureStoreDb(DbContextOptions<FurnitureStoreDb> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }

    // public DbSet<BookTag> BookTags { get; set; }

    // public DbSet<Tag> Tags { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Tag>().ToTable(nameof(Tags), t => t.ExcludeFromMigrations());

    // }

  }

}
