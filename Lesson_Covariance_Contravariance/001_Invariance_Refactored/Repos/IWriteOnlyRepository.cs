using _001_Invariance_Refactored.Entities;

namespace _001_Invariance_Refactored.Repos
{
    public interface IWriteOnlyRepository<in T> where T : Entity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
