using _001_Invariance_Refactored.Entities;

namespace _001_Invariance_Refactored.Repos.Implementations
{
    public class ReadOnlyProductRepository : IReadOnlyRepository<Product>
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, ProductName = "Laptop" },
            new Product { Id = 2, ProductName = "Smartphone"}
        };

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }

}
