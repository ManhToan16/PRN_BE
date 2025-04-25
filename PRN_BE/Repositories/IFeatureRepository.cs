using PRN_BE.Models;
using PRN_BE.Models.Response;

namespace PRN_BE.Repositories;

public interface IFeatureRepository
{
    public Task<BaseDataResponse<List<FeatureModel>>> GetAllFeaturesAsync();
    public Task<BaseDataResponse<FeatureModel>> GetFeatureByIdAsync(int id);
    public Task<BaseDataResponse<List<String>>> GetFeatureByRoomId(int rid);
    public Task<BaseDataResponse<object>> CreateFeatureAsync(FeatureModel feature);
    public Task<BaseDataResponse<object>> UpdateFeatureAsync(int id, FeatureModel feature);
    public Task<BaseDataResponse<object>> DeleteFeatureAsync(int id);
    public Task<BaseDataResponse<List<FeatureModel>>> SearchFeatureAsync(FeatureModel feature);
    
}