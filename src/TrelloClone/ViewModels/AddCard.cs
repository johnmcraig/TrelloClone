using System.ComponentModel.DataAnnotations;

namespace TrelloClone.ViewModels
{
    public class AddCard
    {
        public int Id { get; set; }

        [Required]
        public string Contents { get; set; }
    }
}
