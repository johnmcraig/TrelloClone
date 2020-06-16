namespace Application.Interfaces
{
    public interface IGenericService
    {
         void Add<T>(T entity) where T : class;

         Task<bool> IsArchavied<T>(T entity) where T : class;

         Task<bool> SaveAllChangesAsync();
    }
}