using _001_Invariance.Entities;

namespace _001_Invariance.Repos
{
    //Generic Constraints: The where T : Entity constraint ensures that only types
    //derived from Entity can be used with the repository.
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        T GetById(int id);
        void Update(T entity);
        void Delete(int id);
    }

}
