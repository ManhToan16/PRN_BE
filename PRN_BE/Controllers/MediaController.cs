using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRN_BE.Repositories;

namespace PRN_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IMediaRepository _mediaRepository;

        public MediaController(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        [Authorize]
        [HttpPost("Upload/{roomId}")]
        public async Task<IActionResult> Upload(int roomId, [FromForm] IFormFileCollection uploads)
        {
            var response = await _mediaRepository.CreateMediaByRoomId(roomId, uploads);
            return response.StatusCode == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("upload_thumbnail/{room_id}")]
        public async Task<IActionResult> UploadThumbnail(int room_id, IFormFile upload)
        {
            var response = await _mediaRepository.CreateThumbnailByRoomId(room_id, upload);
            return response.StatusCode == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpGet("{room_id}")]
        public async Task<IActionResult> GetMediaByRoomId(int room_id)
        {
            var response = await _mediaRepository.GetMediaByRoomId(room_id);
            return response.StatusCode == 200 ? Ok(response) : BadRequest(response);
        }
    }
}
