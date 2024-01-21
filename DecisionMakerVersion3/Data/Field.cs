using System.ComponentModel.DataAnnotations;

namespace DecisionMakerVersion3.Data
{
    public class Field
    {
        [Key]
        public int ID {  get; set; }
        public string? Text { get; set; }
        public short Value { get; set; }
        public int CategoryID { get; set; }
        public int RowIndex { get; set; }

        public Category Category { get; set; }
    }
}
