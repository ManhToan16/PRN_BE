using PRN_BE.Models;
using PRN_BE.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PRN_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRepository _locationRepository;

        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAllLocations()
        {
            var result = await _locationRepository.GetLocationsAsync();
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocationById(int id)
        {
            var location = await _locationRepository.GetLocationByIdAsync(id);
            return location.StatusCode == 200 ? Ok(location) : NotFound(location);
        }

        [Authorize]
        [HttpPost("Create")]
        public async Task<IActionResult> CreateLocation([FromBody] LocationModel location)
        {
            var result = await _locationRepository.CreateLocationAsync(location);
            return result.StatusCode == 200 ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateLocations(int id, [FromBody] LocationModel models)
        {
            var result = await _locationRepository.UpdateLocationAsync(id, models);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [Authorize]
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            var result = await _locationRepository.DeleteLocationAsync(id);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }

        [HttpPost("Search")]
        public async Task<IActionResult> SearchLocation(LocationModel model)
        {
            var result = await _locationRepository.SearchLocationAsync(model);
            return result.StatusCode == 200 ? Ok(result) : NotFound(result);
        }
    }
}