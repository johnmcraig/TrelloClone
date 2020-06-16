using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class Card
    {
        public int Id { get; set; }
        [Required]
        public string Contents { get; set; }
        public string Notes { get; set; }
        public int ColumnId { get; set; }
        public Column Column { get; set; }
    }
}
