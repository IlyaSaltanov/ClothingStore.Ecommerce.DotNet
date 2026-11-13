namespace ClothingStore.Api.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;
    public string Category { get; set; } = category;
    public int Inventory { get; set; } = inventory;
    public DateTimeOffset CreatedAt { get; set; } = createdAt;

    public Product(string name, decimal price, string category, int inventory)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        Category = category;
        Inventory = inventory;
        CreatedAt = DateTimeOffset.UtcNow;
    }

    private Product() { }
}

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
    public string PasswordHash { get; set; } = passwordHash;
    public string? Address { get; set; } = address;
    public DateTimeOffset CreatedAt { get; set; } = createdAt;

    public User(string name, string email, string passwordHash, string? address = null)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Address = address;
        CreatedAt = DateTimeOffset.UtcNow;
    }

    private User() { }
}

public class Order
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public decimal Total { get; set; } = total;
    public string Status { get; set; } = status;
    public DateTimeOffset CreatedAt { get; set; } = createdAt;

    public Order(Guid userId, decimal total, string status = "Pending")
    {
        Id = Guid.NewGuid();
        UserId = userId;
        Total = total;
        Status = status;
        CreatedAt = DateTimeOffset.UtcNow;
    }

    private Order() { }
}

public class OrderItem
{
    public long Id { get; set; }
    public Guid OrderId { get; set; } = orderId;
    public Guid ProductId { get; set; } = productId;
    public int Quantity { get; set; } = quantity;
    public decimal UnitPrice { get; set; } = unitPrice;

    public OrderItem(Guid orderId, Guid productId, int quantity, decimal unitPrice)
    {
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    private OrderItem() { }
}

public class ProductImage
{
    public long Id { get; set; }
    public Guid ProductId { get; set; } = productId;
    public string ImageUrl { get; set; } = imageUrl;
    public short SortOrder { get; set; } = sortOrder;

    public ProductImage(Guid productId, string imageUrl, short sortOrder = 0)
    {
        ProductId = productId;
        ImageUrl = imageUrl;
        SortOrder = sortOrder;
    }

    private ProductImage() { }
}

public class Cart
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; } = userId;
    public DateTimeOffset UpdatedAt { get; set; } = updatedAt;

    public Cart(Guid userId)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        UpdatedAt = DateTimeOffset.UtcNow;
    }

    private Cart() { }
}

public class CartItem
{
    public long Id { get; set; }
    public Guid CartId { get; set; } = cartId;
    public Guid ProductId { get; set; } = productId;
    public int Quantity { get; set; } = quantity;

    public CartItem(Guid cartId, Guid productId, int quantity)
    {
        CartId = cartId;
        ProductId = productId;
        Quantity = quantity;
    }

    private CartItem() { }
}

public class Payment
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; } = orderId;
    public decimal Amount { get; set; } = amount;
    public string Status { get; set; } = status;
    public string Method { get; set; } = method;
    public string? TransactionId { get; set; } = transactionId;
    public DateTimeOffset PaidAt { get; set; } = paidAt;

    public Payment(Guid orderId, decimal amount, string method, string status = "Completed", string? transactionId = null)
    {
        Id = Guid.NewGuid();
        OrderId = orderId;
        Amount = amount;
        Method = method;
        Status = status;
        TransactionId = transactionId;
        PaidAt = DateTimeOffset.UtcNow;
    }

    private Payment() { }
}

public class Review
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; } = userId;
    public Guid ProductId { get; set; } = productId;
    public short Rating { get; set; } = rating;
    public string? Comment { get; set; } = comment;
    public DateTimeOffset CreatedAt { get; set; } = createdAt;

    public Review(Guid userId, Guid productId, short rating, string? comment = null)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        ProductId = productId;
        Rating = rating;
        Comment = comment;
        CreatedAt = DateTimeOffset.UtcNow;
    }

    private Review() { }
}