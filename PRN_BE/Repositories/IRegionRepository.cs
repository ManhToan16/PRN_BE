using PRN_BE.Models;
using PRN_BE.Models.Response;

namespace PRN_BE.Repositories;

public interface IRegionRepository
{
    public Task<BaseDataResponse<List<ProvinceModel>>> GetProvincesAsync();
    public Task<BaseDataResponse<List<DistrictModel>>> GetDistrictAsync(int province_id);
    public Task<BaseDataResponse<List<WardModel>>> GetWardAsync(int district_id);
}