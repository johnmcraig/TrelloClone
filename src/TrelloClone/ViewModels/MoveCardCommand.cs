namespace TrelloClone.ViewModels
{
    public class MoveCardCommand
    {
        public int CardId { get; set; }
        public int ColumnId { get; set; }
    }
}