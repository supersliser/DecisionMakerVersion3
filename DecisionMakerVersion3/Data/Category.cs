using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DecisionMakerVersion3.Data
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public short Datatype { get; set; }
        public int Value { get; set; }
        public int FailValue { get; set; }
        public int SuccessValue { get; set; }
        public int ColumnIndex { get; set; }

        public Project Project { get; set; }
    }
}
