using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PRN_BE.Data
{
    [Table("Region")]
    public class Region
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int region_id { get; set; }
        public String? province_name { get; set; }
        public int? province_id { get; set; }
        public String? district_name { get; set; }
        public int? district_id { get; set; }
        public String? ward_name { get; set; }
        public int? ward_id { get; set; }
    }
}
