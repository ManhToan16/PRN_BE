using System.ComponentModel.DataAnnotations.Schema;

namespace PRN_BE.Data
{
    [Table("Location")]
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int location_id { get; set; }
        public string location_name { get; set; }
    }
}
