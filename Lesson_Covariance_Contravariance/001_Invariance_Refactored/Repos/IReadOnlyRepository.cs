using _001_Invariance_Refactored.Entities;

namespace _001_Invariance_Refactored.Repos
{
    public interface IReadOnlyRepository<out T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }


}
