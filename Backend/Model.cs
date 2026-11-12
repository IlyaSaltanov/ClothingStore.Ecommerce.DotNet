using Microsoft.EntityFrameworkCore;
using ClothingStore.Api.Models;

namespace ClothingStore.Api;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Product> Products { get; set; } = null!;
}