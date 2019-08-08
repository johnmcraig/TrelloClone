using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrelloClone.Models
{
    //[Table("Card")]
    public class Card
    {
        public int Id { get; set; }
        public string Contents { get; set; }
        public string Notes { get; set; }
        public int ColumnId { get; set; }
        public Column Column { get; set; }
    }
}
