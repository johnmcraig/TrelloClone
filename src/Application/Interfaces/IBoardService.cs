using Domain.Entities;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBoardService : IGenericService
    {
        Task<Board[]> ListAllBoardsAsync();
        Task<Board> GetBoardAsync(int id);
    }
}