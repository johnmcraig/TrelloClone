using System.Collections.Generic;

namespace TrelloClone.Models
{
  public class Board
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Column> Columns { get; set; } = new List<Column>();
    }
}
