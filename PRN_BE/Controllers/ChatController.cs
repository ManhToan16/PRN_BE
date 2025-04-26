using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRN_BE.Data;
using PRN_BE.Models.Request;
using PRN_BE.Models.Response;
using PRN_BE.Utilities;

namespace PRN_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly TogetherAIService _togetherAIService;
        private readonly EasyBookingBEContext _context;
        public ChatController(TogetherAIService togetherAIService, EasyBookingBEContext context)
        {
            _togetherAIService = togetherAIService;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ChatRequest request)
        {
            var rooms = await _context.Room
            .Include(r => r.Room_Status)
            .Take(10) 
            .ToListAsync();

            var roomDescriptions = rooms.Select(r =>
           $"- Room #{r.room_number} ở {r.location}: {r.num_beds} giường, {r.num_bathrooms} phòng tắm, giá {r.price_per_night:#,##0} VNĐ/đêm. Mô tả: {r.description}");

            var context = string.Join("\n", roomDescriptions);
              var prompt = $"Bạn là một trợ lý ảo giúp người dùng tìm phòng phù hợp trên hệ thống đặt phòng.Dưới đây là danh sách các phòng hiện có trong hệ thống (chỉ trả lời dựa trên dữ liệu này):{context}Người dùng hỏi: {request.Message}Hãy gợi ý những phòng phù hợp và giải thích ngắn gọn.";
            var reply = await _togetherAIService.AskTogetherAsync(prompt);
            return Ok(new ChatResponse { Reply = reply });
        }

    }
}
