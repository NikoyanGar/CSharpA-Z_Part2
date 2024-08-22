using _001_Invariance.Entities;
using _001_Invariance.Repos;

namespace _001_Invariance
{
    //Invariance: The IRepository<T> interface and Repository<T> class are invariant.
    //You cannot assign IRepository<Customer> to IRepository<Entity> or vice versa.
    //The type parameter T must be used exactly as specified.
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepository<Customer> customerRepository = new Repository<Customer>();
            customerRepository.Add(new Customer { Id = 1, Name = "John Doe" });
            var customer = customerRepository.GetById(1);
            Console.WriteLine($"Customer: {customer.Name}");

            IRepository<Product> productRepository = new Repository<Product>();
            productRepository.Add(new Product { Id = 1, ProductName = "Laptop" });
            var product = productRepository.GetById(1);
            Console.WriteLine($"Product: {product.ProductName}");
        }
    }

}
