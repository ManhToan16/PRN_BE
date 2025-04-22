using System.ComponentModel.DataAnnotations;

namespace PRN_BE.Models.Request
{
    public class Room_StatusModel
    {
        public int room_status_id { get; set; }
        [Required]
        public string room_status_name { get; set; }
    }
}
