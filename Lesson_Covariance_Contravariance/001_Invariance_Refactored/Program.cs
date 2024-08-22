using _001_Invariance_Refactored.Repos.Implementations;
using _001_Invariance_Refactored.Repos;
using _001_Invariance_Refactored.Entities;

namespace _001_Invariance_Refactored
{

    internal class Program
    {
        static void Main(string[] args)
        {
            IReadOnlyRepository<Product> productsRepo = new ReadOnlyProductRepository();
            IReadOnlyRepository<Customer> customerRepo = new ReadOnlyCustomerRepository();

            IReadOnlyRepository<Entity> entityRepo = productsRepo; // Covariance
            IReadOnlyRepository<Entity> entityRepo1 = customerRepo; // Covariance


            IWriteOnlyRepository<Entity> writeOnlyEntityRepo1 = new WriteOnlyEntityRepository();
            IWriteOnlyRepository<Entity> writeOnlyEntityRepo2 = new WriteOnlyEntityRepository();

            IWriteOnlyRepository<Product> writeOnlyProductRepo = writeOnlyEntityRepo1; // Contravariance
            IWriteOnlyRepository<Customer> writeOnlyCustomerRepo = writeOnlyEntityRepo2; // Contravariance

            foreach (var entity in entityRepo.GetAll())
            {
                Console.WriteLine(entity.Id);
            }
            Console.WriteLine("--------------------------------------------------------");
            foreach (var entity in entityRepo1.GetAll())
            {
                Console.WriteLine(entity.Id);
            }

            writeOnlyProductRepo.Add(new Product()); // Contravariance
            writeOnlyCustomerRepo.Add(new Customer()); // Contravariance
        }
    }
}
