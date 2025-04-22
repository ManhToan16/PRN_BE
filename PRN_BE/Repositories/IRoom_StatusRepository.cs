using PRN_BE.Models.Request;
using PRN_BE.Models.Response;

namespace PRN_BE.Repositories
{
    public interface IRoom_StatusRepository
    {
        public Task<BaseDataResponse<List<Room_StatusModel>>> GetAllRoom_Status();
        public Task<BaseDataResponse<Room_StatusModel>> GetRoom_StatusById(int id);
        public Task<BaseDataResponse<object>> CreateRoom_Status(Room_StatusModel room_Status);
        public Task<BaseDataResponse<object>> UpdateRoom_Status(int id, Room_StatusModel room_Status);
        public Task<BaseDataResponse<object>> DeleteRoom_Status(int id);
    }
}
