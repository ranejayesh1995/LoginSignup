using System.ComponentModel.DataAnnotations;

namespace LoginSignup.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Email is required")]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage ="Password don't match")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Address is required")]
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }
    }
}
