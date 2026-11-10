using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Api;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Product> Products { get; set; } = null!;
}

public class Product(int id, string name, decimal price)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;
}

public record CreateProductRequest(string Name, decimal Price);