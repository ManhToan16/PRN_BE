using System.ComponentModel.DataAnnotations;

namespace PRN_BE.Models.Request
{
    public class UpdateRoomFeatureModel
    {
        public int room_id { get; set; }
        [Required]
        public List<int> FeatureIds { get; set; }

    }
}
