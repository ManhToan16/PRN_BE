using System.ComponentModel.DataAnnotations;

namespace PRN_BE.Models.Request
{
    public class Payment_StatusModel
    {
        public int payment_id { get; set; }
        [Required]
        public string payment_status_name { get; set; }
    }
}
