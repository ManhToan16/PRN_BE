using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRN_BE.Models.Request;
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
        [Authorize]
        [HttpPost("Create")]
        public async Task<IActionResult> CreateRoom([FromBody] Room_FeatureIdsModel room)
        {
            var result = await _roomRepository.CreateRoomAsync(room);
            return result.StatusCode == 200 ? Ok(result) : BadRequest(result);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateRoom(int id, [FromBody] RoomModel room)
        {
            var result = await _roomRepository.UpdateRoomAsync(id, room);
            return result.StatusCode == 200 ? Ok(result) : BadRequest(result);
        }

        [HttpPost("Search")]
        public async Task<IActionResult> SearchRoom(RoomSearchModel model)
        {
            var result = await _roomRepository.SearchRoomsByLocationAsync(model);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [HttpPost("UpdateStatus/{id}")]
        public async Task<IActionResult> RoomUpdateStatus(int id, [FromBody] RoomUpdateStatus model)
        {
            var result = await _roomRepository.UpdateRoomStatusAsync(id, model);
            return result.StatusCode == 200 ? Ok(result) : BadRequest(result);
        }

        [HttpPost("GetByStatus/{statusId}")]
        public async Task<IActionResult> RoomGetByStatus(int statusId)
        {
            var result = await _roomRepository.GetRoomByStatusIdAsync(statusId);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [Authorize]
        [HttpGet("GetRooms")]
        public async Task<IActionResult> GetRooms()
        {
            var result = await _roomRepository.GetRoomsByUserIdAsync();
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }
    }
}
