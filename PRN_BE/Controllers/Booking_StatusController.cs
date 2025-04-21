using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRN_BE.Models.Request;
using PRN_BE.Repositories;

namespace PRN_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Booking_Status : ControllerBase
    {
        private readonly IBooking_StatusRepository _booking_StatusRepository;

        public Booking_Status(IBooking_StatusRepository booking_StatusRepository)
        {
            _booking_StatusRepository = booking_StatusRepository;
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAllBookingStatus()
        {
            var result = await _booking_StatusRepository.GetAllBooking_Status();
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [Authorize]
        [HttpPost("Create")]
        public async Task<IActionResult> CreateBookingStatus([FromBody] Booking_StatusModel model)
        {
            var result = await _booking_StatusRepository.CreateBooking_Status(model);
            return result.StatusCode == 200 ? Ok(result) : BadRequest(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookingStatusById(int id)
        {
            var result = await _booking_StatusRepository.GetBooking_StatusById(id);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [Authorize]
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateBookingStatus([FromRoute] int id, [FromBody] Booking_StatusModel model)
        {
            var bs = await _booking_StatusRepository.UpdateBooking_Status(id, model);
            return bs.StatusCode == 200 ? Ok(bs) : NotFound(bs);
        }

        [Authorize]
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteBookingStatus(int id)
        {
            var bs = await _booking_StatusRepository.DeleteBooking_Status(id);
            return bs.StatusCode == 200 ? Ok(bs) : NotFound(bs);
        }
    }
}
