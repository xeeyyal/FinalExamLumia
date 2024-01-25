using System.ComponentModel.DataAnnotations;

namespace FinalExamLumia.Areas.Admin.ViewModels
{
    public class CreateSettingVm
    {
        [Required]
        public string Key { get; set; }
        [Required]
        public string Value { get; set; }
    }
}
