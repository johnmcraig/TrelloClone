using System.ComponentModel.DataAnnotations;

namespace TrelloClone.ViewModel
{
    public class AddCard
    {
        public int Id { get; set; }

        [Required]
        public string Contents { get; set; }
    }
}
