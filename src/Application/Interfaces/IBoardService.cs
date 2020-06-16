namespace Application.Interfaces
{
    public interface IBoardService : IGenericService
    {
        Task<Board[]> ListAllBoardsAsync();
        Task<Board> GetBoardAsync(int id);
    }
}