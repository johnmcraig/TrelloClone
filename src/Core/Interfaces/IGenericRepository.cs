using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository
    {
         void Add<T>(T entity) where T : class;

         void Delete<T>(T entity) where T : class;

         Task<bool> SaveAllChangesAsync();
    }
}