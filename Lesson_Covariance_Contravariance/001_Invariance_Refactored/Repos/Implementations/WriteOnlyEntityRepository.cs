using _001_Invariance_Refactored.Entities;

namespace _001_Invariance_Refactored.Repos.Implementations
{
    internal class WriteOnlyEntityRepository : IWriteOnlyRepository<Entity>
    {
        private readonly List<Entity> _entities = new List<Entity>();

        public void Add(Entity product)
        {
            _entities.Add(product);
        }

        public void Update(Entity entity)
        {
            var existingProduct = _entities.FirstOrDefault(p => p.Id == entity.Id);
            if (existingProduct != null)
            {
                existingProduct.Id = entity.Id;
            }
        }

        public void Delete(int id)
        {
            var entity = _entities.FirstOrDefault(p => p.Id == id);
            if (entity != null)
            {
                _entities.Remove(entity);
            }
        }
    }
}
