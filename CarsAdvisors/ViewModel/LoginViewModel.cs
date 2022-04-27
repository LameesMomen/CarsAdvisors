using System.ComponentModel.DataAnnotations;

namespace CarsAdvisors.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        public bool RememberMe { get; set; }
    }
}
