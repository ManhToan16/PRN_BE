using System.ComponentModel.DataAnnotations.Schema;

namespace PRN_BE.Data
{
    [Table("Floor")]
    public class Floor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int floor_id { get; set; }
        public string floor_name { get; set; }
    }
}
