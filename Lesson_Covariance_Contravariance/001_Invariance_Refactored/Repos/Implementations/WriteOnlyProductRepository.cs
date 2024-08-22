using _001_Invariance_Refactored.Entities;

namespace _001_Invariance_Refactored.Repos.Implementations
{
    public class WriteOnlyProductRepository : IWriteOnlyRepository<Product>
    {
        private readonly List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
            }
        }

        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }

}
