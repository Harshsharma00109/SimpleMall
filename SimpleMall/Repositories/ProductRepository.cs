using SimpleMallAPI.Data;
using SimpleMallAPI.Models;
using SimpleMallAPI.Repositories;
using SimpleMallAPI.Repositories.Interfaces;



namespace SimpleMallAPI.Repositories.Implementations;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetAll() => _context.Product.ToList();

    public void Add(Product product)
    {
        _context.Product.Add(product);
        _context.SaveChanges();
    }
}
