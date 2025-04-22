using PRN_BE.Data.Constants;
using PRN_BE.Models.Request;
using PRN_BE.Models.Response;
using PRN_BE.Utitlities;

namespace PRN_BE.Repositories.impl
{

    public class QrGenerateRepository : IQrGenerateRepository
    {
        public async Task<BaseDataResponse<object>> QrGenerate(BankInfoDTO bank)
        {
            try
            {
                string qrCode = await Util.GenQR(970422, "0969146075", "Hoang Manh Toan", bank.amount, "text", "print",
                    bank.content);
                return new BaseDataResponse<object>(
                    statusCode: 200,
                    message: Constants.SUCCESSFUL,
                    data: qrCode
                );
            }
            catch (Exception e)
            {
                return new BaseDataResponse<object>(
                    statusCode: 400,
                    message: Constants.ERROR
                );
            }

        }
    }
}
