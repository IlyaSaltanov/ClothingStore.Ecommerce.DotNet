using ClothingStore.Api;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Connection string"
        + "'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));


var app = builder.Build();

// var products = new List<Product>
// {
//     new(1, "Куртка «Север»", 12990m),
//     new(2, "Вейдерсы Pro", 8490m)
// };

// IReadOnlyList<Product> GetAllProducts()
// {
//     return products;
// }

// IResult GetProductById(int id)
// {
//     foreach (Product product in products)
//     {
//         if (product.Id == id)
//         {
//             return Results.Ok(product);
//         }
//     }

//     return Results.NotFound();
// }

IResult CreateProduct(CreateProductRequest request, ApplicationDbContext database)
{
    Product product = new Product(0, request.Name, request.Price);

    database.Products.Add(product);
    database.SaveChanges();

    return Results.Created($"/api/products/{product.Id}", product);
}

// app.MapGet("/api/products", GetAllProducts);
// app.MapGet("/api/products/{id:int}", GetProductById);

app.MapPost("/api/products", CreateProduct);

app.Run();
