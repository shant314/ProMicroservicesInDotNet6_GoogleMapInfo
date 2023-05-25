using Microsoft.AspNetCore.Mvc;
using ProMicroservicesInDotNet6.GoogleMapInfo.Business;
using ProMicroservicesInDotNet6.GoogleMapInfo.Business.Models;

namespace ProMicroservicesInDotNet6.GoogleMapInfo.Controllers
{
    [Route("[controller]")]
    [Route("[controller]/[action]")]
    [ApiController]
    public class MapInfoController : ControllerBase
    {
        private readonly GoogleDistanceApi _googleDistanceApi;

        public MapInfoController(GoogleDistanceApi googleDistanceApi)
        {
            _googleDistanceApi = googleDistanceApi;
        }
        
        [HttpGet]
        public async Task<GoogleDistanceData> GetDistance(string originCity, string destinationCity)
        {
            return await _googleDistanceApi.GetMapDistance(originCity, destinationCity);
        }
    }
}