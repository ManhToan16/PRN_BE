using PRN_BE.Models.Request;
using PRN_BE.Models.Response;

namespace PRN_BE.Repositories
{
    public interface IRoom_FeatureRepository
    {
        public Task<BaseDataResponse<object>> UpdateRoomFeatureIds(UpdateRoomFeatureModel model);
    }
}
