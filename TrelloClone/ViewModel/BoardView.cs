using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrelloClone.ViewModel
{
    public class BoardView
    {
        public int Id { get; set; }
        public List<Column> Columns = new List<Column>();

        public class Column
        {
            public string Title { get; set; }
            public List<Card> Cards = new List<Card>();
        }

        public class Card
        {
            public string Content { get; set; }
        }
    }
}
