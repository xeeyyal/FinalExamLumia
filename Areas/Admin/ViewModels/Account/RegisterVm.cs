using System.ComponentModel.DataAnnotations;

namespace FinalExamLumia.Areas.Admin.ViewModels
{
    public class RegisterVm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="Password be same")]
        public string ConfirmPassword { get; set; }
    }
}
