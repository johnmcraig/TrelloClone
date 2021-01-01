using System.Collections.Generic;

namespace TrelloClone.ViewModels
{
    public class BoardView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Column> Columns { get; set; } = new List<Column>();

        public class Column
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public List<Card> Cards { get; set; } = new List<Card>();
        }

        public class Card
        {
            public int Id { get; set; }
            public string Content { get; set; }
        }
    }
}
