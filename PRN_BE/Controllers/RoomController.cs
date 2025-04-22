using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRN_BE.Repositories;

namespace PRN_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomRepository _roomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAllRooms()
        {
            var result = await _roomRepository.GetAllRoomsAsync();
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomById(int id)
        {
            var result = await _roomRepository.GetRoomByIdAsync(id);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }


    }
}
