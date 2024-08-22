using _001_Invariance_Refactored.Entities;

namespace _001_Invariance_Refactored.Repos.Implementations
{
    internal class WriteOnlyCustomerRepository : IWriteOnlyRepository<Customer>
    {
        private readonly List<Customer> _customers = new List<Customer>();

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Update(Customer product)
        {
            var existingProduct = _customers.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
            }
        }

        public void Delete(int id)
        {
            var product = _customers.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _customers.Remove(product);
            }
        }
    }
}
