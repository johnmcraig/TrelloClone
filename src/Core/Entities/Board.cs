using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Board : BaseEntity
    {
        public string Title { get; set; }
        public List<Column> Columns { get; set; } = new List<Column>();
    }
}
