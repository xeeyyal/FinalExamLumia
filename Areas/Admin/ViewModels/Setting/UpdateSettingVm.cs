﻿using System.ComponentModel.DataAnnotations;

namespace FinalExamLumia.Areas.Admin.ViewModels
{
    public class UpdateSettingVm
    {
        public string? Key { get; set; }
        [Required]
        public string Value { get; set; }
    }
}
