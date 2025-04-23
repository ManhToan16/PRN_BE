namespace PRN_BE.Models.Request
{
    public class Room_FeatureIdsModel
    {
        public RoomModel Room { get; set; }
        public List<int>? FeatureIds { get; set; }
    }
}
