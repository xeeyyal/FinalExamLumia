using Microsoft.AspNetCore.Identity;

namespace FinalExamLumia.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
