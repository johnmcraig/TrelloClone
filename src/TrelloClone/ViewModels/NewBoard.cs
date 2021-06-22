using System.ComponentModel.DataAnnotations;

namespace TrelloClone.ViewModels
{
    public class NewBoard
    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Title { get; set; }
    }
}
