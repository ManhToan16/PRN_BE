using System.ComponentModel.DataAnnotations;

namespace PRN_BE.Models.Request
{
    public class Booking_StatusModel
    {
        public int booking_status_id { get; set; }
        [Required]
        public string booking_status_name { get; set; }
    }
}
