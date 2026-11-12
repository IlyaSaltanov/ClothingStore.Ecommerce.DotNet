namespace ClothingStore.Api.Models;

public class Product
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    private Product(){}
}