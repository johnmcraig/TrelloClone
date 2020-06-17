using System.ComponentModel.DataAnnotations;


namespace Core.Entities
{
    public class Card : BaseEntity
    {
        [Required]
        public string Contents { get; set; }
        public string Notes { get; set; }
        public int ColumnId { get; set; }
        public Column Column { get; set; }
    }
}
