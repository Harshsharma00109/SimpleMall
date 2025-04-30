using SimpleMallAPI.Data;
using SimpleMallAPI.Models;
using SimpleMallAPI.Repositories.Interfaces;

namespace SimpleMallAPI.Repositories.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll() => _context.Customer.ToList();

        public void Add(Customer Customer)
        {
            _context.Customer.Add(Customer);
            _context.SaveChanges();
        }
    }
}
