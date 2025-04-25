using PRN_BE.Models;
using PRN_BE.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PRN_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureRepository _featureRepository;

        public FeatureController(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAllFeature()
        {
            var result = await _featureRepository.GetAllFeaturesAsync();
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [HttpGet("get-by-rid/{rid}")]
        public async Task<IActionResult> GetFeaturesByRoomId(int rid)
        {
            var result = await _featureRepository.GetFeatureByRoomId(rid);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatureById(int id)
        {
            var result = await _featureRepository.GetFeatureByIdAsync(id);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [Authorize]
        [HttpPost("Create")]
        public async Task<IActionResult> CreateFeature([FromBody] FeatureModel model)
        {
            var result = await _featureRepository.CreateFeatureAsync(model);
            return result.StatusCode == 200 ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateFeature(int id, [FromBody] FeatureModel model)
        {
            var result = await _featureRepository.UpdateFeatureAsync(id, model);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [Authorize]
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            var result = await _featureRepository.DeleteFeatureAsync(id);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [HttpPost("Search")]
        public async Task<IActionResult> SearchFeature(FeatureModel model)
        {
            var result = await _featureRepository.SearchFeatureAsync(model);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }
        
    }
}