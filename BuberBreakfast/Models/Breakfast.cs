namespace BuberBreakfast.Models;

public class Breakfast
{
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public decimal Price { get; }
    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset UpdatedAt { get; }


    public Breakfast(
        Guid id,
        string name,
        string description,
        decimal price,
        DateTimeOffset createdAt,
        DateTimeOffset updatedAt)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
    
}