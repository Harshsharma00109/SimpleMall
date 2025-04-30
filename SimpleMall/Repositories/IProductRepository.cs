using SimpleMallAPI.Models;


namespace SimpleMallAPI.Repositories.Interfaces;

public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    void Add(Product product);
}
