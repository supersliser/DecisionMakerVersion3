using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DecisionMakerVersion3.Data
{
    [PrimaryKey("ProjectID", "UserID")]
    public class ProjectUser
    {

        [Key]
        [ForeignKey("Project")]
        public int ProjectID { get; set; }
        [Key]
        [ForeignKey("AspNetUsers")]
        public string? UserID { get; set; }

        [ForeignKey("ProjectID")]
        public Project Project { get; set; }
        public ApplicationUser AspNetUsers { get; set; }
    }
}
