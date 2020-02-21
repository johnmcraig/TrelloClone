using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrelloClone.ViewModel
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
