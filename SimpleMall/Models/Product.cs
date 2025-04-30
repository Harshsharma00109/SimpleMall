namespace SimpleMallAPI.Models;

public class Product
{
    public int Id { get; set; }                  // Primary key
    public string Name { get; set; }             // Product name
    public decimal Price { get; set; }           // Product price
}
