using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRN_BE.Models.Request;
using PRN_BE.Repositories;

namespace PRN_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room_FeatureController : ControllerBase
    {

            private readonly IRoom_FeatureRepository _room_feature_repository;

            public Room_FeatureController(IRoom_FeatureRepository room_feature_repository)
            {
                _room_feature_repository = room_feature_repository;
            }

            [HttpPut("UpdateFeature")]
            public async Task<IActionResult> UpdateRoomFeatureIds([FromBody] UpdateRoomFeatureModel model)
            {
                var result = await _room_feature_repository.UpdateRoomFeatureIds(model);
                return result.StatusCode == 200 ? Ok(result) : BadRequest(result);
            }

        

    }
}
