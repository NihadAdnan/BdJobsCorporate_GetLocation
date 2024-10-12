using BdJobsCorporate_GetLocation.DTO.DTOs;
using BdJobsCorporate_GetLocation.Handler.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BdJobsCorporate_GetLocation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationHandler _locationHandler;

        public LocationController(ILocationHandler locationHandler)

        {
            _locationHandler = locationHandler;
        }

        [HttpPost("GetLocations")]
        public async Task<IActionResult> GetLocations([FromBody] LocationRequestDTO request)
        {
            var locations = await _locationHandler.Handle(request);

            if (locations.Count == 0)
            {
                return Ok(new { Error = "0", BdDistrict = "null" });
            }

            return Ok(new
            {
                Error = "0",
                BdDistrict = locations
            });
        }
    }
}
