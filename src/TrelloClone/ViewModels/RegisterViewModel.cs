using System.ComponentModel.DataAnnotations;

namespace TrelloClone.ViewModels
{
    public class RegisterViewModel
    {  
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and a max of {1} characters long")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmed password must be the same")]
        public string ConfirmPassword { get; set; }
    }
}
