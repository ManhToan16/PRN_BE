using PRN_BE.Models.Response;
using PRN_BE.Models.Request;

namespace PRN_BE.Repositories
{

    public interface IQrGenerateRepository
    {
        public Task<BaseDataResponse<object>> QrGenerate(BankInfoDTO bankInfo);
    }
}
