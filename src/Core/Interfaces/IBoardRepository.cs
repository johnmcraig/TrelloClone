using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBoardRepository : IGenericRepository
    {
        Task<List<Board>> GetBoardsAsync();
        Task<Board> GetBoardByIdAsync(int id);
    }
}