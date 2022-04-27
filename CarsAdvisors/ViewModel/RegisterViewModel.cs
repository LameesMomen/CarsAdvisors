using System.ComponentModel.DataAnnotations;

namespace CarsAdvisors.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string username { get; set; }
        [Required]
        [MinLength(10,ErrorMessage ="Email must be at least 10 Character")]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [Compare("password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string confirmPassword { get; set; }

    }
}
