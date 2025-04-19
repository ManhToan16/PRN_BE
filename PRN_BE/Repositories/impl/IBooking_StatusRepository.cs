using PRN_BE.Models.Request;
using PRN_BE.Models.Response;

namespace PRN_BE.Repositories.impl
{
    public interface IBooking_StatusRepository
    {
        public Task<BaseDataResponse<List<Booking_StatusModel>>> GetAllBooking_Status();
        public Task<BaseDataResponse<Booking_StatusModel>> GetBooking_StatusById(int id);
        public Task<BaseDataResponse<object>> CreateBooking_Status(Booking_StatusModel booking_status);
        public Task<BaseDataResponse<object>> UpdateBooking_Status(int id, Booking_StatusModel booking_status);
        public Task<BaseDataResponse<object>> DeleteBooking_Status(int id);
    }
}
