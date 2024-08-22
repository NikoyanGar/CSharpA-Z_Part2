using _001_Invariance_Refactored.Entities;

namespace _001_Invariance_Refactored.Repos.Implementations
{
    internal class ReadOnlyCustomerRepository : IReadOnlyRepository<Customer>
    {
        private readonly List<Customer> _customer = new List<Customer>
        {
            new Customer { Id = 1, Name = "Laptop" },
            new Customer { Id = 2, Name = "Smartphone"}
        };

        public IEnumerable<Customer> GetAll()
        {
            return _customer;
        }

        public Customer GetById(int id)
        {
            return _customer.FirstOrDefault(p => p.Id == id);
        }
    }
}