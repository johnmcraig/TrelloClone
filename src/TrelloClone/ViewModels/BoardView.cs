using System.Collections.Generic;

namespace TrelloClone.ViewModels
{
    public class BoardView
    {
        public int Id { get; set; }
        public readonly List<Column> Columns = new List<Column>();

        public class Column
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public readonly List<Card> Cards = new List<Card>();
        }

        public class Card
        {
            public int Id { get; set; }
            public string Content { get; set; }
        }
    }
}
