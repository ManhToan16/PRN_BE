using PRN_BE.Models.Request;
using PRN_BE.Models.Response;

namespace PRN_BE.Repositories
{
    public interface IRoomRepository
    {
        public Task<BaseDataResponse<List<Room_FeatureIdsModel>>> GetAllRoomsAsync();
        public Task<BaseDataResponse<Room_FeatureIdsModel>> GetRoomByIdAsync(int id);
        public Task<BaseDataResponse<object>> CreateRoomAsync(Room_FeatureIdsModel room);
        public Task<BaseDataResponse<object>> UpdateRoomAsync(int id, RoomModel room);
        public Task<BaseDataResponse<object>> UpdateRoomStatusAsync(int id, RoomUpdateStatus model);
        public Task<BaseDataResponse<List<RoomModel>>> SearchRoomsByLocationAsync(RoomSearchModel model);
        public Task<BaseDataResponse<List<Room_FeatureIdsModel>>> GetRoomByStatusIdAsync(int id);
        public Task<BaseDataResponse<object>> CheckDuplicateRoomAsync(RoomModel model);
        public Task<BaseDataResponse<List<RoomModel>>> GetRoomsByUserIdAsync();
    }
}
