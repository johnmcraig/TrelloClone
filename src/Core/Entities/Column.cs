using System.Collections.Generic;

namespace Core.Entities
{
    public class Column : BaseEntity
    {
        public string Title { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();
        public int BoardId { get; set; }
    }
}
