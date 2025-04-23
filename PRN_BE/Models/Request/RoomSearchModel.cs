namespace PRN_BE.Models.Request
{
    public class RoomSearchModel
    {
        public string location { get; set; }
        public double? minPrice { get; set; }
        public double? maxPrice { get; set; }

    }
}
