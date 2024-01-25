using FinalExamLumia.Models.Common;

namespace FinalExamLumia.Models
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string FbLink { get; set; }
        public string TwLink { get; set; }
        public string InstaLink { get; set; }
        public string LinkedinLink { get; set; }

    }
}
