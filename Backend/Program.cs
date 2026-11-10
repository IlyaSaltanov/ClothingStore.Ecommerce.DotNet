using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Connection string"
        + "'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));


var app = builder.Build();

var products = new List<Product>
{
    new(1, "Куртка «Север»", 12990m),
    new(2, "Вейдерсы Pro", 8490m)
};

IReadOnlyList<Product> GetAllProducts()
{
    return products;
}

IResult GetProductById(int id)
{
    foreach (Product product in products)
    {
        if (product.Id == id)
        {
            return Results.Ok(product);
        }
    }

    return Results.NotFound();
}

app.MapGet("/api/products", GetAllProducts);
app.MapGet("/api/products/{id:int}", GetProductById);

app.Run();

public class Product
{
    public int Id { get; set;}
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Product> Products { get; set; } = null!;
}
