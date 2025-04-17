using System.ComponentModel.DataAnnotations.Schema;

namespace PRN_BE.Data
{
    [Table("Payment_Status")]
    public class Payment_Status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int payment_id { get; set; }
        public string payment_status_name { get; set; }
    }
}
