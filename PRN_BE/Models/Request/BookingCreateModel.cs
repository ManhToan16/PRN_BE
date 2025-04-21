using System.ComponentModel.DataAnnotations;

namespace PRN_BE.Models.Request
{
    public class BookingCreateModel
    {
        [Required] public int room_id { get; set; }
        [Required] public DateTime start_date_booking { get; set; }
        [Required] public DateTime end_date_booking { get; set; }
        [Required] public int num_adults { get; set; }
        [Required] public int num_children { get; set; }
        [Required] public double price { get; set; }
        [Required] public int payment_status { get; set; }
    }
}
