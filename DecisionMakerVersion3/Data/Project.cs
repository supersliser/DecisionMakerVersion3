using System.ComponentModel.DataAnnotations;

namespace DecisionMakerVersion3.Data
{
    public class Project
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime EditedAt { get; set; }
        public short ColourR { get; set; }
        public short ColourG { get; set; }
        public short ColourB { get; set; }

        public ICollection<ProjectUser> projectUsers { get; set; }
    }
}
