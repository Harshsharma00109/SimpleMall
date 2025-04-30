using SimpleMallAPI.Models;

namespace SimpleMallAPI.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        void Add(Customer customers);
    }
}
