using PRN_BE.Models;
using PRN_BE.Models.Response;

namespace PRN_BE.Repositories;

public interface ILocationRepository
{
    public Task<BaseDataResponse<List<LocationModel>>> GetLocationsAsync();
    public Task<BaseDataResponse<LocationModel>> GetLocationByIdAsync(int id);
    public Task<BaseDataResponse<object>> CreateLocationAsync(LocationModel location);
    public Task<BaseDataResponse<object>> UpdateLocationAsync(int id, LocationModel location);
    public Task<BaseDataResponse<object>> DeleteLocationAsync(int id);
    public Task<BaseDataResponse<List<LocationModel>>> SearchLocationAsync(LocationModel location);
    
}