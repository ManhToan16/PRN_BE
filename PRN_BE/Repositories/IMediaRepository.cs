using PRN_BE.Models.Request;
using PRN_BE.Models.Response;

namespace PRN_BE.Repositories
{
    public interface IMediaRepository
    {
        public Task<BaseDataResponse<List<MediaModel>>> GetMediaByRoomId(int roomId);
        public Task<BaseDataResponse<string>> CreateMediaByRoomId(int room_id, IFormFileCollection uploadModels);
        public Task<BaseDataResponse<string>> CreateThumbnailByRoomId(int room_id, IFormFile uploadModels);
        public Task<BaseDataResponse<string>> SaveRoomMediaToDB(int room_id, List<byte[]> pictures);
    }
}
